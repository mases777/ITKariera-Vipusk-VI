using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().ToList();
            int sum = 0;
            foreach (var item in nums)
            {
                sum += int.Parse(ReverseString(item));
            }
            Console.WriteLine(sum);
        }

        private static string ReverseString(string item)
        {
            char[] chars = item.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
