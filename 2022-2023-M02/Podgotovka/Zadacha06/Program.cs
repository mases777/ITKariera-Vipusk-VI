using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(',').Select(int.Parse).ToList();
            var evenNumber = new List<int>();
            var oddNumber = new List<int>();
            var number5 = new List<int>();
            foreach (var item in numbers)
            {
                if (EvenNumber(item))
                {
                    evenNumber.Add(item);
                }
                if (OddNumber(item))
                {
                    oddNumber.Add(item);
                }
                if (NumberSum(item, 5))
                {
                    number5.Add(item);
                }
            }
            Console.WriteLine(String.Join(", ", evenNumber));
            Console.WriteLine(String.Join(", ", oddNumber));
            Console.WriteLine(String.Join(", ", number5));

        }
        private static bool NumberSum(int item, int v)
        {
            int sum = 0;
            while (item > 0)
            {
                sum += item % 10;
                item /= 10;
            }
            if (sum % 10 == v)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool OddNumber(int item)
        {
            if (item % 2 == 1)
            {
                return true;
            }
            return false;
        }

        private static bool EvenNumber(int item)
        {
            if (item % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
