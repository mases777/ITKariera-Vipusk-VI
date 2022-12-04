using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lego = 0, monopoly = 0, puzzle = 0, robot = 0;
            for (int i = 0; i < n; i++)
            {
                var typeGift = Console.ReadLine();
                switch (typeGift)
                {
                    case "lego": lego++; break;
                    case "monopoly": monopoly++; break;
                    case "puzzle": puzzle++; break;
                    case "robot": robot++; break;
                }
            }
            Console.WriteLine($"Lego: {lego}");
            Console.WriteLine($"Monopoly: {monopoly}");
            Console.WriteLine($"Puzzles: {puzzle}");
            Console.WriteLine($"Robots: {robot}");
        }
    }
}
