using System;
using System.Collections.Generic;

namespace Zadacha07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> wordLetter = new List<string>();
            List<string> wordA = new List<string>();
            List<string> others = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                if (word[0] == word[word.Length - 1])
                {
                    wordLetter.Add(word);
                }
                int letterA = 0;
                foreach (var item in word)
                {
                    if (item == 'a')
                    {
                        letterA++;
                    }
                }
                if (letterA >= 2)
                {
                    wordA.Add(word);
                }
                if (word[0] != word[word.Length - 1] 
                    && letterA < 2)
                {
                    others.Add(word);
                }
            }
            Console.WriteLine(String.Join(", ", wordLetter));
            Console.WriteLine(String.Join(", ", wordA));
            Console.WriteLine(String.Join(", ", others));

        }
    }
}
