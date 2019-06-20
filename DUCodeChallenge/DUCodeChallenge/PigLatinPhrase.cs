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
            string punctuation = "";

            // Store all the non-letter chars in "punctuation"
            for (int i = 0; i < sentence.Length; i++)
            {
                if (!Char.IsLetter(sentence[i]) && sentence[i] != ' ')
                {
                    punctuation += sentence[i];
                }
            }

            // Strip all non-letter chars
            strippedSentence = new string((from c in sentence
                                           where char.IsWhiteSpace(c) || char.IsLetter(c)
                                           select c).ToArray());

            List<string> words = strippedSentence.Split(' ').ToList();

            // Convert each word in 'words'
            for (int i = 0; i < words.Count(); i++)
            {
                // Catches 'out of range exception' when 'words' contains an empty string.
                if (String.IsNullOrEmpty(words[i]))
                {
                    continue;
                }

                string convertedWord = ConvertWord(words[i]);

                if (i == 0) // Don't add a space before the first word in the translated sentence.

                {
                    pigLatinSentence += convertedWord;
                }
                else
                {
                    pigLatinSentence += $" {convertedWord}";
                }
            }

            // Add all non-letter chars to the end of the converted sentence.
            // This is imperfect, but it allows for any string to be passed in without breaking the program.
            pigLatinSentence += punctuation.ToString();

            return pigLatinSentence;
        }

        public string ConvertWord(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Any(vowel => vowel == word[0])) // First letter is a vowel
            {
                return VowelWordBuilder(word);
            }
            else // First letter is a consonant
            {
                return ConsonantWordBuilder(word);
            }             
        }

        // Convert words that start with vowels.
        public string VowelWordBuilder(string word)
        {
            return word + "way";
        }

        // Convert words that start with consonants.
        public string ConsonantWordBuilder(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int firstVowelIndex = int.MaxValue;

            // Find the index of the first vowel in the word
            for(int i = 0; i < word.Length; i++)
            {
                if (vowels.Any(vowel => vowel == word[i]))
                {
                    firstVowelIndex = i;
                    break;
                }
            }

            // Split the string after the first vowel and build the converted word
            string secondHalf = word.Substring(firstVowelIndex);
            string firstHalf = word.Substring(0, firstVowelIndex);
            string pigLatinWord = secondHalf + firstHalf + "ay";

            return pigLatinWord;
        }
    }
}
