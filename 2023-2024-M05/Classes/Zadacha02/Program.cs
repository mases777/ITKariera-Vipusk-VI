using System;
using System.Collections.Generic;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rationals = new List<RationalNumber>();
            for (int i = 0; i < 3; i++)
            {
                var n = int.Parse(Console.ReadLine());
                var m = int.Parse(Console.ReadLine());
                rationals.Add(
                    new RationalNumber(n, m)
                    ) ;
            }
            Console.WriteLine(string.Join("\n", rationals));

        }
    }
}
