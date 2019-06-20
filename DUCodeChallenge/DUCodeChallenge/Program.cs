using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test for exercise #2
            List<string> words = new List<string> { "dog", "Fishing", "have", "Middle", "", "C" };
            MiddleChar mc = new MiddleChar();

            foreach (var word in words)
            {
                Console.WriteLine(mc.GetMiddleChar(word));
            }

            //Test for exercise 3
            PigLatinPhrase pig1 = new PigLatinPhrase("Hello world !");
            PigLatinPhrase pig2 = new PigLatinPhrase("Hello world!");
            PigLatinPhrase pig3 = new PigLatinPhrase("Pig latin is cool");

            Console.WriteLine(pig1.BuildPigLatinSentence());
            Console.WriteLine(pig2.BuildPigLatinSentence());
            Console.WriteLine(pig3.BuildPigLatinSentence());
        }
    }
}
