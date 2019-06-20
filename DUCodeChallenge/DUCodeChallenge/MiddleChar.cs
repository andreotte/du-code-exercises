using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCodeChallenge
{
    class MiddleChar
    {
        //Exercise #2
        public string GetMiddleChar(string word)
        {
            int wordLength = word.Count();

            if (wordLength == 0)
            {
                return "";
            }

            bool wordLengthIsEven = wordLength % 2 == 0;

            if (wordLengthIsEven)
            {
                string firstMiddleChar = word[(wordLength / 2) - 1].ToString();
                string secondMiddleChar = word[(wordLength / 2)].ToString();

                return firstMiddleChar + secondMiddleChar;
            }
            else
            {
                string middleChar = word[wordLength / 2].ToString();

                return middleChar;
            }
        }
    }
}
