using System;
using System.Linq;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            int target = line[0];
            int number = line[1];

            Console.WriteLine(Convert(number, target));
            Console.WriteLine(Convert1(number, target));
        }

        private static string Convert1(int number, int target)
        {
            double sum = 0, pow = 0;
            while (number > 0)
            {
                var current = number % 10;
                sum += current * Math.Pow(target, pow);
                pow++;
                number /= 10;
            }
            return sum.ToString();
        }

        private static string Convert(int number, int target)
        {
            string result = string.Empty;
            while (number > 0)
            {
                var remainder = number % target;
                result = string.Concat(remainder.ToString(), result);
                number /= target;
            }
            return result;
        }
    }
}
