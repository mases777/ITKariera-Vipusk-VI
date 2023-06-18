using System;
using System.Diagnostics;

namespace Zadacha02
{
    internal class Program
    {
        private static void MesureTime(Action metod)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            metod();
            timer.Stop();
            Console.WriteLine($"Time = {timer.ElapsedMilliseconds} ms");
        }
        static void Main(string[] args)
        {
            int index = 0;
            int key = 54321987;
            const int n = 100000000;
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            Console.WriteLine("Linear Seacrh ...");
            MesureTime(() => index = Search.Linear(numbers, key));
            Console.WriteLine(index == -1 ? false : true);

            Console.WriteLine("Binary Seacrh ...");
            MesureTime(() => index = Search.Binary(numbers, key));
            Console.WriteLine(index == -1 ? false : true);

        }
    }
}
