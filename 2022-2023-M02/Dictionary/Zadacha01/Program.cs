using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower().Split().ToArray();
            var wordCounter = new Dictionary<string, int>();
            var oddCounter = new List<string>();

            foreach (var item in words)
            {
                if (wordCounter.ContainsKey(item))
                {
                    wordCounter[item]++;
                }
                else
                {
                    wordCounter[item] = 1;
                }
            }

            foreach (var item in wordCounter)
            {
                if (item.Value % 2 == 1)
                {
                    oddCounter.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", oddCounter));
        }
    }
}
