using RudimentaryCryptography.Library.Ciphers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RudimentaryCryptography.Library
{
    public class CaesarExtractor
    {
        private readonly CaesarCipher _caesarCipher;
        private readonly char[] _alphabet;
        private readonly Dictionary<char, double> _letterFrequencies;

        public CaesarExtractor(char[] alphabet, Dictionary<char, double> letterFrequencies)
        {
            _caesarCipher = new CaesarCipher(alphabet, default);
            _alphabet = alphabet;
            _letterFrequencies = letterFrequencies;
        }

        public int RecoverKey(string processedMessage)
        {
            Dictionary<int, double> keyLikelihood = new();
            for (int i = 1; i < _alphabet.Length; i++)
            {
                int key = i;
                _caesarCipher.Key = key;
                string decryptedMessage = _caesarCipher.Decrypt(processedMessage);
                Dictionary<char, int> letterCount = GetLetterCount(decryptedMessage);
                double likelihood = 0;
                foreach ((char letter, double frequency) in _letterFrequencies)
                {
                    if (letterCount.TryGetValue(letter, out int count))
                        likelihood += count * frequency;
                }

                keyLikelihood.Add(key, likelihood);
            }

            return keyLikelihood.MaxBy(keyValue => keyValue.Value).Key;
        } 

        private static Dictionary<char, int> GetLetterCount(string message)
        {
            Dictionary<char, int> letterCount = new();
            for (int i = 0; i < message.Length; i++)
            {
                char character = message[i];
                if (!char.IsLetter(character))
                    continue;

                if (letterCount.ContainsKey(character))
                    letterCount[character]++;
                else
                    letterCount[character] = 1;
            }

            return letterCount;
        }
    }
}
