using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinCap
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator");
                Convert();
                run = Continue();

            }
        }

        public static void Convert()
        {
            Console.WriteLine("Write a word to convert to pig latin: ");

            const string vowels = "AEIOUaeiou";
            List<string> newWords = new List<string>();
            string sentence = Console.ReadLine();

            foreach(string newword in sentence.Split(' '))
            {
                string firstLetter = newword.Substring(0, 1);
                string restOfWord = newword.Substring(1, newword.Length - 1);
                int currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1) 
                {
                    newWords.Add(restOfWord + firstLetter + "ay");
                }
                else 
                {
                    newWords.Add(newword + "way");
                }
            }

            for (int i = 0; i < newWords.Count; i++)
            {
                Console.Write(" " + newWords[i]);

            }
        }

        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to run this program agian?(y/n)");
            string input = Console.ReadLine().ToLower();
            bool stuff;
            if (input == "y")
            {
                stuff = true;
            }
            else if (input == "n")
            {
                stuff = false; 
            }
            else
            {
                Console.WriteLine("Sorry I didn't catch that.");
                stuff = Continue();
            }

            return stuff;
        }
    }
}
