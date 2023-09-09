using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rationals = new List<RationalNumber>();
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < input.Length; i += 2)
            {
                rationals.Add(
                    new RationalNumber(input[i], input[i + 1])
                    );
            }
            Console.WriteLine(string.Join("; ", rationals));



            //var rationals = new List<RationalNumber>();
            //for (int i = 0; i < 3; i++)
            //{
            //    var n = int.Parse(Console.ReadLine());
            //    var m = int.Parse(Console.ReadLine());
            //    rationals.Add(
            //        new RationalNumber(n, m)
            //        ) ;
            //}
            //Console.WriteLine(string.Join("\n", rationals));

        }
    }
}
