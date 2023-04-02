using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> playerStats = new Dictionary<string, int>();
            SortedDictionary<string, int> playerStats = new SortedDictionary<string, int>();
            char[] separators = new char[] { ' ', '-' };
            string input;
            while ((input = Console.ReadLine()) != "End of match")
            {
                var info = input
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string player = info[0];
                int passes = int.Parse(info[1]);

                if (playerStats.ContainsKey(player))
                {
                    playerStats[player] += passes;
                }
                else
                {
                    playerStats[player] = passes;
                }
            }

            //foreach (var item in playerStats.OrderBy(x => x.Key))
            foreach (var item in playerStats)
            {
                Console.WriteLine($"{item.Key} has passed {item.Value} passes.");
            }

        }
    }
}
