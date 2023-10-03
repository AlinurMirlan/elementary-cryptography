using System.Text;

namespace RudimentaryCryptography.Library.Ciphers
{
    public class CorrespondenceCipher : ICipher
    {
        private readonly Dictionary<char, int> _originalAlphabetLookup;
        private readonly Dictionary<char, int> _reorderedAlphabetLookup;

        public CorrespondenceCipher(char[] originalAlphabet, char[] reorderedAlphabet)
        {
            HashSet<char> originalSet = new(originalAlphabet);
            HashSet<char> reorderedSet = new(reorderedAlphabet);
            if (!originalSet.SetEquals(reorderedSet))
                throw new ArgumentException($"{nameof(originalAlphabet)} must have the exact same letters as the {nameof(reorderedAlphabet)}");

            ReorderedAlphabet = reorderedAlphabet;
            OriginalAlphabet = originalAlphabet;

            int counter = 0;
            _originalAlphabetLookup = originalAlphabet.ToDictionary(character => character, _ => counter++, new KeyComparer());
            counter = 0;
            _reorderedAlphabetLookup = reorderedAlphabet.ToDictionary(character => character, _ => counter++, new KeyComparer());
        }

        public char[] ReorderedAlphabet { get; }
        public char[] OriginalAlphabet { get; }

        public string Encrypt(string message) => Cipher(message, ReorderedAlphabet, _originalAlphabetLookup);
        public string Decrypt(string message) => Cipher(message, OriginalAlphabet, _reorderedAlphabetLookup);
        private static string Cipher(string message, char[] reorderedAplhabet, Dictionary<char, int> originalAlphabetLookup)
        {
            StringBuilder cipheredMessageBuilder = new();
            for (int i = 0; i < message.Length; i++)
            {
                char character = message[i];
                if (!char.IsLetter(character))
                {
                    cipheredMessageBuilder.Append(character);
                    continue;
                }

                if (originalAlphabetLookup.TryGetValue(character, out int position))
                    cipheredMessageBuilder.Append(reorderedAplhabet[position]);
                else
                    throw new InvalidOperationException();
            }

            return cipheredMessageBuilder.ToString();
        }

    }
}