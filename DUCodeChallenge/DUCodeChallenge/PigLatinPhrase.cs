using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCodeChallenge
{
    class PigLatinPhrase
    {
        public string sentence{ get; set; }

        public PigLatinPhrase(string sentence)
        {
            this.sentence = sentence;
        }

        public string BuildPigLatinSentence()
        {
            string pigLatinSentence = "";
            string strippedSentence = "";
            char punctuation = ' ';

            for(int i = 0; i < sentence.Length; i++)
            {
                if (!Char.IsLetter(sentence[i]) && sentence[i] != ' ')
                {
                    punctuation = sentence[i];
                    strippedSentence = sentence.Remove(i);
                    break;
                }
                else
                {
                    strippedSentence = sentence;
                }
            }

            List<string> words = strippedSentence.Split(' ').ToList();

            for (int i = 0; i < words.Count(); i++)
            {
                if (String.IsNullOrEmpty(words[i]))
                {
                    continue;
                }

                string convertedWord = ConvertWords(words[i]);

                if (i == 0)
                {
                    pigLatinSentence += convertedWord;
                }
                else
                {
                    pigLatinSentence += $" {convertedWord}";
                }
            }

            pigLatinSentence += punctuation.ToString();

            return pigLatinSentence;
        }

        public string ConvertWords(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Any(vowel => vowel == word[0]))
            {
                return VowelBuilder(word);
            }
            else
            {
                return ConsonantBuilder(word);
            }             
        }

        // Convert words that start with vowels.
        public string VowelBuilder(string word)
        {
            return word + "way";
        }

        // Convert words that start with consonants.
        public string ConsonantBuilder(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int firstVowelIndex = int.MaxValue;

            for(int i = 0; i < word.Length; i++)
            {
                if (vowels.Any(vowel => vowel == word[i]))
                {
                    firstVowelIndex = i;
                    break;
                }
            }

            string secondHalf = word.Substring(firstVowelIndex);
            string firstHalf = word.Substring(0, firstVowelIndex);
            string pigLatinWord = secondHalf + firstHalf + "ay";

            return pigLatinWord;
        }
    }
}
