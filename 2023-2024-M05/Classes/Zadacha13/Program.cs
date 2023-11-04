using System;
using System.Linq;

namespace Zadacha13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = numbers.Count();
            Console.WriteLine(count);

            int sum = numbers.Sum();
            Console.WriteLine(sum);

        }
    }
}
