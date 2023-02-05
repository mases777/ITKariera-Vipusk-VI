using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            foreach (var item in nums)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    result.Add(item);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(String.Join(" ", result));

        }
    }
}
