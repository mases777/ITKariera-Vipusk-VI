using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int a = 0; a <= 9; a++)
                for (int b = 1; b <= 9; b += 2)
                    for (int c = 4; c <= 7; c += 3)
                        for (int d = 0; d <= 9; d++)
                            if (a + d == n)
                                Console.Write($"{a}{b}{c}{d} ");
            Console.WriteLine();

        }
    }
}
