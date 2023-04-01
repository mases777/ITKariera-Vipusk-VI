using System;
using System.Linq;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", nums.OrderByDescending(x => x).Take(3)));
        }
    }
}
