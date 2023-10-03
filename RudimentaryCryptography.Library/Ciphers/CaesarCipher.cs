using System.Text;

namespace RudimentaryCryptography.Library.Ciphers
{
    public class CaesarCipher : ICipher
    {
        private readonly Dictionary<char, int> _alphabetLookup;
        private readonly int _alphabetLength;
        private readonly char[] _alphabet;

        public CaesarCipher(char[] alphabet, int key)
        {
            int counter = 0;
            _alphabetLookup = alphabet.ToDictionary(letter => letter, _ => counter++, new KeyComparer());
            _alphabetLength = alphabet.Length;
            _alphabet = alphabet;
            Key = key;
        }

        public int Key { get; set; }

        public string Encrypt(string message) => Cipher(message, Key, true);

        public string Decrypt(string message) => Cipher(message, Key, false);

        private string Cipher(string message, int key, bool direction)
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
