using System;
using System.Linq;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            double average = 0;

            min = arr.Min();
            max = arr.Max();
            sum = arr.Sum();
            average = arr.Average();

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
