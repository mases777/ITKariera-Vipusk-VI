using System;
using System.Diagnostics;

namespace Zadacha01
{
    internal class Program
    {
        public static Stopwatch sw = new Stopwatch();
        static void Main(string[] args)
        {
            //var numbers = new int[] { 9, -9, 8, -8, 7, -7, 6, -6, 5, -5, 4, -4, 3, -3, 2, -2, 1, -1, 0 };

            //Console.WriteLine(string.Join(" ", numbers));

            //Sort.Shuffle(numbers);
            //Console.WriteLine(string.Join(" ", numbers));

            //Sort.Selection(numbers);
            //Console.WriteLine(string.Join(" ", numbers));

            const int n = 20000;
            var numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            Sort.Shuffle(numbers);

            sw.Restart();
            Sort.Selection(numbers);
            sw.Stop();
            Console.WriteLine($"Selection: {sw.ElapsedMilliseconds}");

            Sort.Shuffle(numbers);

            sw.Restart();
            Sort.Bubble(numbers);
            sw.Stop();
            Console.WriteLine($"Bubble: {sw.ElapsedMilliseconds}");
        }
    }
}
