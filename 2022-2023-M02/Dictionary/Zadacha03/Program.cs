using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int next = int.Parse(Console.ReadLine());
                nums.Add(next);
            }
            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");

        }
    }
}
