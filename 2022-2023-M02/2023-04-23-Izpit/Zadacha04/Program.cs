using System;
using System.Collections.Generic;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char item in input)
            {
                if (item != ' ')
                {

                    if (dict.ContainsKey(item))
                    {
                        dict[item]++;
                    }
                    else
                    {
                        dict[item] = 1;
                    }
                }
            }
            foreach (KeyValuePair<char, int> item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
