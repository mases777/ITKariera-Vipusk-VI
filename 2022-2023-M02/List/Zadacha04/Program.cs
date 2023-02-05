using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha04
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

            int min = nums.Min();
            int max = nums.Max();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == min || nums[i] == max)
                {
                    result.Add(nums[i]);
                }
            }

            result.Sort();
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
