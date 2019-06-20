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
            MiddleChar mc = new MiddleChar();
            List<string> words = new List<string> { "dog", "Fishing", "have", "Middle", "", "C" };

            Console.WriteLine("Exercise #2 - Find middle char(s)");

            foreach (var word in words)
            {
                Console.WriteLine($"{word}: { mc.GetMiddleChar(word)}");
            }

            //Test for exercise #3

            List<string> sentences = new List<string>(){ "Hello world !", "Hello world!", "Pig latin is cool", "Pig lat!123in !  23 !is cool!" };

            Console.WriteLine();
            Console.WriteLine("Exercise #3 - Pig latin translator");

            foreach (string sentence in sentences)
            {
                PigLatinPhrase pig = new PigLatinPhrase(sentence);
                Console.WriteLine($"{sentence} => {pig.BuildPigLatinSentence()}");
            }
        }
    }
}
