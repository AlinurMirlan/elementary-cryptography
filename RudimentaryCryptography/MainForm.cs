using RudimentaryCryptography.Library;
using RudimentaryCryptography.Library.Ciphers;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RudimentaryCryptography
{
    public partial class MainForm : Form
    {
        private const string _alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFrequencyPlotView();
            LoadFrequencyGridView();
        }

        private void LoadFrequencyPlotView()
        {
            ScottPlot.Plot plot = frequencyPlot.Plot;
            plot.Title("Frequency Plot");
            plot.XLabel("Alphabet");
            plot.YLabel("Frequency");
            PlotFrequency(
                letterFrequencies: Constants.RussianLetterFrequencies
                    .OrderByDescending(letter => letter.Frequency),
                label: "Alphabet");
        }

        private void PlotFrequency(IEnumerable<LetterFrequency> letterFrequencies, string label)
        {
            ScottPlot.Plot plot = frequencyPlot.Plot;
            plot.AddScatter(
                xs: Enumerable.Range(1, letterFrequencies.Count()).Select(n => (double)n).ToArray(),
                ys: letterFrequencies.Select(letter => letter.Frequency).ToArray(),
                label: label);
            plot.Legend();
            frequencyPlot.Refresh();
        }

        private void LoadFrequencyGridView()
        {
            foreach (LetterFrequency letter in Constants.RussianLetterFrequencies)
                letterFrequencyGrid.Rows.Add(letter.Letter, letter.Frequency);

            letterFrequencyGrid.Sort(letterFrequencyGrid.Columns[1], ListSortDirection.Descending);
        }

        private void PlotLetterFrequencies()
        {
            frequencyPlot.Plot.Clear();
            LoadFrequencyPlotView();
            originalLetterFrequencyGrid.Rows.Clear();
            processedLetterFrequencyGrid.Rows.Clear();
            ExtractAndPlotFrequency(textBoxTextToProcess.Text, "Original", originalLetterFrequencyGrid);
            ExtractAndPlotFrequency(textBoxProcessedOutput.Text, "Processed", processedLetterFrequencyGrid);
        }

        private static IEnumerable<LetterFrequency> ExtractLetterFrequencies(string? message)
        {
            if (string.IsNullOrEmpty(message))
                return Enumerable.Empty<LetterFrequency>();

            Dictionary<char, int> letterCount = new(new KeyComparer());
            foreach (char character in message)
            {
                if (!char.IsLetter(character))
                    continue;

                if (letterCount.ContainsKey(character))
                    letterCount[character]++;
                else
                    letterCount.Add(character, 1);
            }

            int totalCharacters = letterCount.Values.Sum();
            LinkedList<LetterFrequency> letterFrequenciesList = new();
            foreach ((char letter, int count) in letterCount)
            {
                letterFrequenciesList.AddLast(new LetterFrequency(
                    Letter: letter,
                    Frequency: ((double)count / totalCharacters) * 100));
            }

            return letterFrequenciesList;
        }

        private void ExtractAndPlotFrequency(string? message, string legend, DataGridView dataGrid)
        {
            IEnumerable<LetterFrequency> letterFrequencies = ExtractLetterFrequencies(message)
                .OrderByDescending(letter => letter.Frequency);
            foreach (LetterFrequency letter in letterFrequencies)
            {
                dataGrid.Rows.Add(letter.Letter, letter.Frequency);
            }

            PlotFrequency(letterFrequencies, legend);
        }

        private void ButtonCipher_Click(object sender, EventArgs e) => Cipher(true);

        private void ButtonDecipher_Click(object sender, EventArgs e)
        {
            if (!radioCaesarLikelihood.Checked)
            {
                Cipher(false);
                return;
            }

            CaesarExtractor caesarExtractor = new(
                _alphabet.ToCharArray(),
                Constants.RussianLetterFrequencies
                    .ToDictionary(l => l.Letter, l => l.Frequency));

            int key = caesarExtractor.RecoverKey(textBoxTextToProcess.Text);
            textBoxKey.Text = key.ToString();
            ICipher cipher = GetCaesarCipher();
            Cipher(false, cipher);
        }

        private void Cipher(bool direction, ICipher? cipher = null)
        {
            if (string.IsNullOrEmpty(textBoxTextToProcess.Text))
                return;

            if (cipher is null)
            {
                try
                {
                    if (radioCorrespondence.Checked)
                        cipher = GetCorrespondenceCipher();

                    if (radioCaesar.Checked)
                        cipher = GetCaesarCipher();

                    if (radioTrithemius.Checked)
                        cipher = GetTrithemiusCipher();
                }
                catch (ArgumentException)
                {
                    return;
                }
            }

            string originalMessage = textBoxTextToProcess.Text;
            string? cipheredMessage = direction
                ? cipher?.Encrypt(originalMessage)
                : cipher?.Decrypt(originalMessage);
            textBoxProcessedOutput.Text = cipheredMessage;
            PlotLetterFrequencies();
        }

        private ICipher GetCorrespondenceCipher()
        {
            string reorderedAlphabet = textBoxKey.Text;
            if (reorderedAlphabet.Length != _alphabet.Length)
            {
                ShowWarningBox("""
                        Lenght of the key must match that of the alphabet.
                        """);
                throw new ArgumentException(textBoxKey.Text);
            }

            try
            {
                return new CorrespondenceCipher(_alphabet.ToCharArray(), reorderedAlphabet.ToCharArray());
            }
            catch (ArgumentException)
            {
                ShowWarningBox("""
                        Key contains duplicate or 'alien' letters.
                        It must be a reordered alphabet.
                        """);
                throw new ArgumentException(textBoxKey.Text);
            }
        }

        private ICipher GetCaesarCipher()
        {
            if (int.TryParse(textBoxKey.Text, out int shift))
                return new CaesarCipher(_alphabet.ToCharArray(), shift);
            else
            {
                ShowWarningBox("""
                    Key must be a number
                    """);
                throw new ArgumentException(textBoxKey.Text);
            }
        }

        private ICipher GetTrithemiusCipher()
        {
            string keyword = textBoxKey.Text;
            if (string.IsNullOrEmpty(keyword))
            {
                ShowWarningBox("""
                    You did not enter a key. 
                    It must be any word made up only of the given alphabet letters. 
                    """);
                throw new ArgumentException(textBoxKey.Text);
            }

            foreach (char character in keyword)
            {
                if (!_alphabet.Contains(character, StringComparison.InvariantCultureIgnoreCase))
                {
                    ShowWarningBox("""
                        Key contains 'alien' letters.
                        It must be any word made up only of the given alphabet letters. 
                        """);
                    throw new ArgumentException(textBoxKey.Text);
                }
            }

            return new TrithemiusCipher(_alphabet.ToCharArray(), keyword);
        }

        private void RadioCorrespondence_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RadioCaesar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioTrithemius_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClearKey_Click(object sender, EventArgs e)
        {
            textBoxKey.Text = string.Empty;
            textBoxKey.Focus();
        }

        private void ButtonGenerateKey_Click(object sender, EventArgs e)
        {
            if (radioCorrespondence.Checked)
                textBoxKey.Text = ShuffleText(_alphabet);

            Random random = new();
            if (radioCaesar.Checked)
            {
                textBoxKey.Text = random.Next(int.MinValue, int.MaxValue).ToString();
            }

            if (radioTrithemius.Checked)
            {
                StringBuilder wordBuilder = new();
                for (int i = 0; i < random.Next(6, 100); i++)
                    wordBuilder.Append(_alphabet[random.Next(_alphabet.Length)]);

                textBoxKey.Text = wordBuilder.ToString();
            }
        }

        private static string ShuffleText(string text)
        {
            List<char> characters = text.ToList();
            Random random = new();
            int charactersLength = characters.Count;
            StringBuilder shuffledBuilder = new();
            for (int i = 0; i < charactersLength; i++)
            {
                int randomIndex = random.Next(0, charactersLength - i);
                char randomCharacter = characters[randomIndex];
                shuffledBuilder.Append(randomCharacter);
                characters.Remove(randomCharacter);
            }

            return shuffledBuilder.ToString();
        }

        private void RadioCaesarLikelihood_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCaesarLikelihood.Checked)
            {
                textBoxKey.Enabled = false;
                buttonCipher.Enabled = false;
                buttonClearKey.Enabled = false;
                buttonGenerateKey.Enabled = false;
            }
            else
            {
                textBoxKey.Enabled = true;
                buttonCipher.Enabled = true;
                buttonClearKey.Enabled = true;
                buttonGenerateKey.Enabled = true;
            }
        }

        private void ButtonOpenText_Click(object sender, EventArgs e)
        {
            if (openTextFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openTextFileDialog.FileName;
                try
                {
                    string fileContent = File.ReadAllText(selectedFile);
                    textBoxTextToProcess.Text = fileContent;
                }
                catch (IOException ex)
                {
                    ShowErrorBox($"An error occurred while reading the file: {ex.Message}");
                }
            }
        }

        private void ButtonSaveText_Click(object sender, EventArgs e)
        {
            if (saveTextFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveTextFileDialog.FileName;
                string textToSave = textBoxProcessedOutput.Text;

                try
                {
                    File.WriteAllText(filePath, textToSave);
                    ShowSuccessBox("Text saved to file successfully!");
                }
                catch (IOException ex)
                {
                    ShowErrorBox($"An error occurred while saving the file: {ex.Message}");
                }
            }
        }

        private static void ShowWarningBox(string text)
        {
            MessageBox.Show(text + "\nMake sure of it and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void ShowErrorBox(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void ShowSuccessBox(string text)
        {
            MessageBox.Show(text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
