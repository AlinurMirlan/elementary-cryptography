using System.Text;

namespace RudimentaryCryptography.Library.Ciphers
{
    public class TrithemiusCipher : ICipher
    {
        private readonly Dictionary<char, int> _alphabetLookup;
        private readonly int _alphabetLength;
        private readonly char[] _alphabet;
        private readonly string _keyword;

        public TrithemiusCipher(char[] alphabet, string keyword)
        {
            int counter = 0;
            _alphabetLookup = alphabet.ToDictionary(letter => letter, _ => counter++, new KeyComparer());
            _alphabetLength = alphabet.Length;
            _alphabet = alphabet;
            _keyword = keyword;
        }

        public string Encrypt(string message) => Cipher(message, _keyword, true);

        public string Decrypt(string message) => Cipher(message, _keyword, false);

        private string Cipher(string message, string keyword, bool direction)
        {
            StringBuilder cipheredMessageBuilder = new();
            int keywordLength = keyword.Length;
            for (int i = 0; i < message.Length; i++)
            {
                char character = message[i];
                if (!char.IsLetter(character))
                {
                    cipheredMessageBuilder.Append(character);
                    continue;
                }

                int key;
                if (_alphabetLookup.TryGetValue(keyword[i % keywordLength], out int keyPosition))
                    key = keyPosition;
                else
                    throw new InvalidOperationException();

                if (_alphabetLookup.TryGetValue(character, out int position))
                {
                    int shift = direction ? position + key : position - key;
                    int shiftedPosition = shift % _alphabetLength;
                    if (shiftedPosition < 0)
                        shiftedPosition = _alphabetLength + shiftedPosition;

                    cipheredMessageBuilder.Append(_alphabet[shiftedPosition]);
                }
                else
                    throw new InvalidOperationException();
            }

            return cipheredMessageBuilder.ToString();
        }
    }
}
