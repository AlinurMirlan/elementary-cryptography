namespace RudimentaryCryptography
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            frequencyPlot = new ScottPlot.FormsPlot();
            tableLayoutPanel4 = new TableLayoutPanel();
            keyBox = new GroupBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            textBoxKey = new RichTextBox();
            buttonClearKey = new Button();
            buttonGenerateKey = new Button();
            cipherMethodBox = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            radioCorrespondence = new RadioButton();
            radioCaesar = new RadioButton();
            radioTrithemius = new RadioButton();
            radioCaesarLikelihood = new RadioButton();
            alphabetBox = new GroupBox();
            tableLayoutPanel13 = new TableLayoutPanel();
            textBoxAlphabet = new RichTextBox();
            letterFrequencyBox = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            letterFrequencyGrid = new DataGridView();
            Letter = new DataGridViewTextBoxColumn();
            LetterFrequency = new DataGridViewTextBoxColumn();
            originalLetterFrequencyGrid = new DataGridView();
            OriginalLetter = new DataGridViewTextBoxColumn();
            ProcessedLetterFrequency = new DataGridViewTextBoxColumn();
            processedLetterFrequencyGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            processResultBox = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            textBoxProcessedOutput = new RichTextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            buttonSaveText = new Button();
            textToProcessBox = new GroupBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            textBoxTextToProcess = new RichTextBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            buttonCipher = new Button();
            buttonDecipher = new Button();
            buttonOpenText = new Button();
            openTextFileDialog = new OpenFileDialog();
            saveTextFileDialog = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            keyBox.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            cipherMethodBox.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            alphabetBox.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            letterFrequencyBox.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)letterFrequencyGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originalLetterFrequencyGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)processedLetterFrequencyGrid).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            processResultBox.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            textToProcessBox.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1217, 710);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.Controls.Add(frequencyPlot, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(letterFrequencyBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1211, 349);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // frequencyPlot
            // 
            frequencyPlot.Dock = DockStyle.Fill;
            frequencyPlot.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            frequencyPlot.Location = new Point(671, 4);
            frequencyPlot.Margin = new Padding(6, 4, 6, 4);
            frequencyPlot.Name = "frequencyPlot";
            frequencyPlot.Size = new Size(534, 341);
            frequencyPlot.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(keyBox, 0, 2);
            tableLayoutPanel4.Controls.Add(cipherMethodBox, 0, 0);
            tableLayoutPanel4.Controls.Add(alphabetBox, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            tableLayoutPanel4.Size = new Size(320, 343);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // keyBox
            // 
            keyBox.Controls.Add(tableLayoutPanel9);
            keyBox.Dock = DockStyle.Fill;
            keyBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            keyBox.Location = new Point(3, 218);
            keyBox.Name = "keyBox";
            keyBox.Size = new Size(314, 122);
            keyBox.TabIndex = 2;
            keyBox.TabStop = false;
            keyBox.Text = "Key";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(textBoxKey, 0, 0);
            tableLayoutPanel9.Controls.Add(buttonClearKey, 0, 1);
            tableLayoutPanel9.Controls.Add(buttonGenerateKey, 1, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 24);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 51F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 49F));
            tableLayoutPanel9.Size = new Size(308, 95);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // textBoxKey
            // 
            textBoxKey.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel9.SetColumnSpan(textBoxKey, 2);
            textBoxKey.Dock = DockStyle.Fill;
            textBoxKey.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKey.Location = new Point(3, 3);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(302, 42);
            textBoxKey.TabIndex = 0;
            textBoxKey.Text = "";
            // 
            // buttonClearKey
            // 
            buttonClearKey.BackColor = Color.DarkCyan;
            buttonClearKey.Dock = DockStyle.Fill;
            buttonClearKey.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClearKey.ForeColor = SystemColors.ButtonHighlight;
            buttonClearKey.Location = new Point(3, 51);
            buttonClearKey.Name = "buttonClearKey";
            buttonClearKey.Size = new Size(148, 41);
            buttonClearKey.TabIndex = 1;
            buttonClearKey.Text = "Clear";
            buttonClearKey.UseVisualStyleBackColor = false;
            buttonClearKey.Click += ButtonClearKey_Click;
            // 
            // buttonGenerateKey
            // 
            buttonGenerateKey.BackColor = Color.DarkCyan;
            buttonGenerateKey.Dock = DockStyle.Fill;
            buttonGenerateKey.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGenerateKey.ForeColor = SystemColors.ButtonHighlight;
            buttonGenerateKey.Location = new Point(157, 51);
            buttonGenerateKey.Name = "buttonGenerateKey";
            buttonGenerateKey.Size = new Size(148, 41);
            buttonGenerateKey.TabIndex = 2;
            buttonGenerateKey.Text = "Generate";
            buttonGenerateKey.UseVisualStyleBackColor = false;
            buttonGenerateKey.Click += ButtonGenerateKey_Click;
            // 
            // cipherMethodBox
            // 
            cipherMethodBox.Controls.Add(tableLayoutPanel5);
            cipherMethodBox.Dock = DockStyle.Fill;
            cipherMethodBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cipherMethodBox.Location = new Point(3, 3);
            cipherMethodBox.Name = "cipherMethodBox";
            cipherMethodBox.Size = new Size(314, 131);
            cipherMethodBox.TabIndex = 0;
            cipherMethodBox.TabStop = false;
            cipherMethodBox.Text = "Cipher Method";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(radioCorrespondence, 0, 0);
            tableLayoutPanel5.Controls.Add(radioCaesar, 0, 1);
            tableLayoutPanel5.Controls.Add(radioTrithemius, 0, 2);
            tableLayoutPanel5.Controls.Add(radioCaesarLikelihood, 0, 3);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 24);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9981289F));
            tableLayoutPanel5.Size = new Size(308, 104);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // radioCorrespondence
            // 
            radioCorrespondence.AutoSize = true;
            radioCorrespondence.Dock = DockStyle.Fill;
            radioCorrespondence.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioCorrespondence.Location = new Point(3, 3);
            radioCorrespondence.Name = "radioCorrespondence";
            radioCorrespondence.Size = new Size(302, 20);
            radioCorrespondence.TabIndex = 0;
            radioCorrespondence.TabStop = true;
            radioCorrespondence.Text = "Correspondence";
            radioCorrespondence.UseVisualStyleBackColor = true;
            radioCorrespondence.CheckedChanged += RadioCorrespondence_CheckedChanged;
            // 
            // radioCaesar
            // 
            radioCaesar.AutoSize = true;
            radioCaesar.Dock = DockStyle.Fill;
            radioCaesar.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioCaesar.Location = new Point(3, 29);
            radioCaesar.Name = "radioCaesar";
            radioCaesar.Size = new Size(302, 20);
            radioCaesar.TabIndex = 1;
            radioCaesar.TabStop = true;
            radioCaesar.Text = "Caesar";
            radioCaesar.UseVisualStyleBackColor = true;
            radioCaesar.CheckedChanged += RadioCaesar_CheckedChanged;
            // 
            // radioTrithemius
            // 
            radioTrithemius.AutoSize = true;
            radioTrithemius.Dock = DockStyle.Fill;
            radioTrithemius.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioTrithemius.Location = new Point(3, 55);
            radioTrithemius.Name = "radioTrithemius";
            radioTrithemius.Size = new Size(302, 20);
            radioTrithemius.TabIndex = 2;
            radioTrithemius.TabStop = true;
            radioTrithemius.Text = "Trithemius";
            radioTrithemius.UseVisualStyleBackColor = true;
            radioTrithemius.CheckedChanged += RadioTrithemius_CheckedChanged;
            // 
            // radioCaesarLikelihood
            // 
            radioCaesarLikelihood.AutoSize = true;
            radioCaesarLikelihood.Dock = DockStyle.Fill;
            radioCaesarLikelihood.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioCaesarLikelihood.Location = new Point(3, 81);
            radioCaesarLikelihood.Name = "radioCaesarLikelihood";
            radioCaesarLikelihood.Size = new Size(302, 20);
            radioCaesarLikelihood.TabIndex = 3;
            radioCaesarLikelihood.TabStop = true;
            radioCaesarLikelihood.Text = "Caesar Likelihood";
            radioCaesarLikelihood.UseVisualStyleBackColor = true;
            radioCaesarLikelihood.CheckedChanged += RadioCaesarLikelihood_CheckedChanged;
            // 
            // alphabetBox
            // 
            alphabetBox.Controls.Add(tableLayoutPanel13);
            alphabetBox.Dock = DockStyle.Fill;
            alphabetBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            alphabetBox.Location = new Point(3, 140);
            alphabetBox.Name = "alphabetBox";
            alphabetBox.Size = new Size(314, 72);
            alphabetBox.TabIndex = 3;
            alphabetBox.TabStop = false;
            alphabetBox.Text = "Alphabet";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Controls.Add(textBoxAlphabet, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 24);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Size = new Size(308, 45);
            tableLayoutPanel13.TabIndex = 0;
            // 
            // textBoxAlphabet
            // 
            textBoxAlphabet.BackColor = SystemColors.GradientInactiveCaption;
            textBoxAlphabet.Dock = DockStyle.Fill;
            textBoxAlphabet.Enabled = false;
            textBoxAlphabet.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAlphabet.Location = new Point(3, 3);
            textBoxAlphabet.Name = "textBoxAlphabet";
            textBoxAlphabet.Size = new Size(302, 39);
            textBoxAlphabet.TabIndex = 0;
            textBoxAlphabet.Text = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            // 
            // letterFrequencyBox
            // 
            letterFrequencyBox.Controls.Add(tableLayoutPanel6);
            letterFrequencyBox.Dock = DockStyle.Fill;
            letterFrequencyBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            letterFrequencyBox.Location = new Point(329, 3);
            letterFrequencyBox.Name = "letterFrequencyBox";
            letterFrequencyBox.Size = new Size(333, 343);
            letterFrequencyBox.TabIndex = 5;
            letterFrequencyBox.TabStop = false;
            letterFrequencyBox.Text = "Letter Frequency";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Controls.Add(letterFrequencyGrid, 0, 0);
            tableLayoutPanel6.Controls.Add(originalLetterFrequencyGrid, 1, 0);
            tableLayoutPanel6.Controls.Add(processedLetterFrequencyGrid, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 24);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(327, 316);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // letterFrequencyGrid
            // 
            letterFrequencyGrid.AllowUserToAddRows = false;
            letterFrequencyGrid.AllowUserToDeleteRows = false;
            letterFrequencyGrid.BackgroundColor = SystemColors.InactiveCaption;
            letterFrequencyGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            letterFrequencyGrid.Columns.AddRange(new DataGridViewColumn[] { Letter, LetterFrequency });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            letterFrequencyGrid.DefaultCellStyle = dataGridViewCellStyle1;
            letterFrequencyGrid.Dock = DockStyle.Fill;
            letterFrequencyGrid.GridColor = Color.DarkCyan;
            letterFrequencyGrid.Location = new Point(3, 3);
            letterFrequencyGrid.Name = "letterFrequencyGrid";
            letterFrequencyGrid.ReadOnly = true;
            letterFrequencyGrid.RowHeadersVisible = false;
            letterFrequencyGrid.RowHeadersWidth = 51;
            letterFrequencyGrid.RowTemplate.Height = 29;
            letterFrequencyGrid.Size = new Size(103, 310);
            letterFrequencyGrid.TabIndex = 0;
            // 
            // Letter
            // 
            Letter.HeaderText = "L";
            Letter.MinimumWidth = 6;
            Letter.Name = "Letter";
            Letter.ReadOnly = true;
            Letter.Width = 30;
            // 
            // LetterFrequency
            // 
            LetterFrequency.HeaderText = "F";
            LetterFrequency.MinimumWidth = 6;
            LetterFrequency.Name = "LetterFrequency";
            LetterFrequency.ReadOnly = true;
            LetterFrequency.Width = 50;
            // 
            // originalLetterFrequencyGrid
            // 
            originalLetterFrequencyGrid.AllowUserToAddRows = false;
            originalLetterFrequencyGrid.AllowUserToDeleteRows = false;
            originalLetterFrequencyGrid.BackgroundColor = SystemColors.InactiveCaption;
            originalLetterFrequencyGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            originalLetterFrequencyGrid.Columns.AddRange(new DataGridViewColumn[] { OriginalLetter, ProcessedLetterFrequency });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            originalLetterFrequencyGrid.DefaultCellStyle = dataGridViewCellStyle2;
            originalLetterFrequencyGrid.Dock = DockStyle.Fill;
            originalLetterFrequencyGrid.GridColor = Color.DarkCyan;
            originalLetterFrequencyGrid.Location = new Point(112, 3);
            originalLetterFrequencyGrid.Name = "originalLetterFrequencyGrid";
            originalLetterFrequencyGrid.ReadOnly = true;
            originalLetterFrequencyGrid.RowHeadersVisible = false;
            originalLetterFrequencyGrid.RowHeadersWidth = 51;
            originalLetterFrequencyGrid.RowTemplate.Height = 29;
            originalLetterFrequencyGrid.Size = new Size(103, 310);
            originalLetterFrequencyGrid.TabIndex = 1;
            // 
            // OriginalLetter
            // 
            OriginalLetter.HeaderText = "OL";
            OriginalLetter.MinimumWidth = 6;
            OriginalLetter.Name = "OriginalLetter";
            OriginalLetter.ReadOnly = true;
            OriginalLetter.Width = 35;
            // 
            // ProcessedLetterFrequency
            // 
            ProcessedLetterFrequency.HeaderText = "F";
            ProcessedLetterFrequency.MinimumWidth = 6;
            ProcessedLetterFrequency.Name = "ProcessedLetterFrequency";
            ProcessedLetterFrequency.ReadOnly = true;
            ProcessedLetterFrequency.Width = 50;
            // 
            // processedLetterFrequencyGrid
            // 
            processedLetterFrequencyGrid.AllowUserToAddRows = false;
            processedLetterFrequencyGrid.AllowUserToDeleteRows = false;
            processedLetterFrequencyGrid.BackgroundColor = SystemColors.InactiveCaption;
            processedLetterFrequencyGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            processedLetterFrequencyGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            processedLetterFrequencyGrid.DefaultCellStyle = dataGridViewCellStyle3;
            processedLetterFrequencyGrid.Dock = DockStyle.Fill;
            processedLetterFrequencyGrid.GridColor = Color.DarkCyan;
            processedLetterFrequencyGrid.Location = new Point(221, 3);
            processedLetterFrequencyGrid.Name = "processedLetterFrequencyGrid";
            processedLetterFrequencyGrid.ReadOnly = true;
            processedLetterFrequencyGrid.RowHeadersVisible = false;
            processedLetterFrequencyGrid.RowHeadersWidth = 51;
            processedLetterFrequencyGrid.RowTemplate.Height = 29;
            processedLetterFrequencyGrid.Size = new Size(103, 310);
            processedLetterFrequencyGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "PL";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "F";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 50;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(processResultBox, 0, 0);
            tableLayoutPanel3.Controls.Add(textToProcessBox, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 358);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1211, 349);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // processResultBox
            // 
            processResultBox.Controls.Add(tableLayoutPanel7);
            processResultBox.Dock = DockStyle.Fill;
            processResultBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            processResultBox.Location = new Point(608, 3);
            processResultBox.Name = "processResultBox";
            processResultBox.Size = new Size(600, 343);
            processResultBox.TabIndex = 3;
            processResultBox.TabStop = false;
            processResultBox.Text = "Processed Output";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(textBoxProcessedOutput, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 24);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel7.Size = new Size(594, 316);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // textBoxProcessedOutput
            // 
            textBoxProcessedOutput.BackColor = SystemColors.GradientInactiveCaption;
            textBoxProcessedOutput.Dock = DockStyle.Fill;
            textBoxProcessedOutput.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProcessedOutput.Location = new Point(3, 3);
            textBoxProcessedOutput.Name = "textBoxProcessedOutput";
            textBoxProcessedOutput.ReadOnly = true;
            textBoxProcessedOutput.Size = new Size(588, 253);
            textBoxProcessedOutput.TabIndex = 1;
            textBoxProcessedOutput.Text = "";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(buttonSaveText, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 262);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(588, 51);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // buttonSaveText
            // 
            buttonSaveText.BackColor = Color.MediumSeaGreen;
            buttonSaveText.Dock = DockStyle.Fill;
            buttonSaveText.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveText.ForeColor = SystemColors.ButtonHighlight;
            buttonSaveText.Location = new Point(3, 3);
            buttonSaveText.Name = "buttonSaveText";
            buttonSaveText.Size = new Size(582, 45);
            buttonSaveText.TabIndex = 0;
            buttonSaveText.Text = "Save";
            buttonSaveText.UseVisualStyleBackColor = false;
            buttonSaveText.Click += ButtonSaveText_Click;
            // 
            // textToProcessBox
            // 
            textToProcessBox.Controls.Add(tableLayoutPanel11);
            textToProcessBox.Dock = DockStyle.Fill;
            textToProcessBox.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textToProcessBox.Location = new Point(3, 3);
            textToProcessBox.Name = "textToProcessBox";
            textToProcessBox.Size = new Size(599, 343);
            textToProcessBox.TabIndex = 2;
            textToProcessBox.TabStop = false;
            textToProcessBox.Text = "Text to Process";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(textBoxTextToProcess, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 24);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel11.Size = new Size(593, 316);
            tableLayoutPanel11.TabIndex = 2;
            // 
            // textBoxTextToProcess
            // 
            textBoxTextToProcess.BackColor = SystemColors.GradientInactiveCaption;
            textBoxTextToProcess.Dock = DockStyle.Fill;
            textBoxTextToProcess.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTextToProcess.Location = new Point(3, 3);
            textBoxTextToProcess.Name = "textBoxTextToProcess";
            textBoxTextToProcess.Size = new Size(587, 253);
            textBoxTextToProcess.TabIndex = 0;
            textBoxTextToProcess.Text = "";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel12.Controls.Add(buttonCipher, 1, 0);
            tableLayoutPanel12.Controls.Add(buttonDecipher, 2, 0);
            tableLayoutPanel12.Controls.Add(buttonOpenText, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 262);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(587, 51);
            tableLayoutPanel12.TabIndex = 1;
            // 
            // buttonCipher
            // 
            buttonCipher.BackColor = Color.DarkCyan;
            buttonCipher.Dock = DockStyle.Fill;
            buttonCipher.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCipher.ForeColor = SystemColors.ButtonHighlight;
            buttonCipher.Location = new Point(198, 3);
            buttonCipher.Name = "buttonCipher";
            buttonCipher.Size = new Size(189, 45);
            buttonCipher.TabIndex = 0;
            buttonCipher.Text = "Cipher";
            buttonCipher.UseVisualStyleBackColor = false;
            buttonCipher.Click += ButtonCipher_Click;
            // 
            // buttonDecipher
            // 
            buttonDecipher.BackColor = Color.DarkCyan;
            buttonDecipher.Dock = DockStyle.Fill;
            buttonDecipher.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDecipher.ForeColor = SystemColors.ButtonHighlight;
            buttonDecipher.Location = new Point(393, 3);
            buttonDecipher.Name = "buttonDecipher";
            buttonDecipher.Size = new Size(191, 45);
            buttonDecipher.TabIndex = 1;
            buttonDecipher.Text = "Decipher";
            buttonDecipher.UseVisualStyleBackColor = false;
            buttonDecipher.Click += ButtonDecipher_Click;
            // 
            // buttonOpenText
            // 
            buttonOpenText.BackColor = Color.LightSeaGreen;
            buttonOpenText.Dock = DockStyle.Fill;
            buttonOpenText.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOpenText.ForeColor = SystemColors.ButtonHighlight;
            buttonOpenText.Location = new Point(3, 3);
            buttonOpenText.Name = "buttonOpenText";
            buttonOpenText.Size = new Size(189, 45);
            buttonOpenText.TabIndex = 2;
            buttonOpenText.Text = "Open";
            buttonOpenText.UseVisualStyleBackColor = false;
            buttonOpenText.Click += ButtonOpenText_Click;
            // 
            // openTextFileDialog
            // 
            openTextFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // saveTextFileDialog
            // 
            saveTextFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1217, 710);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            keyBox.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            cipherMethodBox.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            alphabetBox.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            letterFrequencyBox.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)letterFrequencyGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)originalLetterFrequencyGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)processedLetterFrequencyGrid).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            processResultBox.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            textToProcessBox.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox keyBox;
        private TableLayoutPanel tableLayoutPanel9;
        private RichTextBox textBoxKey;
        private Button buttonClearKey;
        private Button buttonGenerateKey;
        private GroupBox cipherMethodBox;
        private TableLayoutPanel tableLayoutPanel5;
        private RadioButton radioCorrespondence;
        private RadioButton radioCaesar;
        private RadioButton radioTrithemius;
        private GroupBox alphabetBox;
        private TableLayoutPanel tableLayoutPanel13;
        private RichTextBox textBoxAlphabet;
        private ScottPlot.FormsPlot frequencyPlot;
        private GroupBox letterFrequencyBox;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView letterFrequencyGrid;
        private DataGridView originalLetterFrequencyGrid;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox processResultBox;
        private GroupBox textToProcessBox;
        private TableLayoutPanel tableLayoutPanel11;
        private RichTextBox textBoxTextToProcess;
        private TableLayoutPanel tableLayoutPanel12;
        private Button buttonCipher;
        private Button buttonDecipher;
        private DataGridView processedLetterFrequencyGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Letter;
        private DataGridViewTextBoxColumn LetterFrequency;
        private DataGridViewTextBoxColumn OriginalLetter;
        private DataGridViewTextBoxColumn ProcessedLetterFrequency;
        private RadioButton radioCaesarLikelihood;
        private TableLayoutPanel tableLayoutPanel7;
        private RichTextBox textBoxProcessedOutput;
        private TableLayoutPanel tableLayoutPanel8;
        private Button buttonSaveText;
        private Button buttonOpenText;
        private OpenFileDialog openTextFileDialog;
        private SaveFileDialog saveTextFileDialog;
    }
}