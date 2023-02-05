using System;
using System.Linq;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(',')
                .ToList();

            list.Reverse();

            foreach (var item in list)
            {
                var parts = item.Trim().Split(' ').ToList();
                Console.WriteLine($"{parts[1]} {parts[0]}");
            }

        }
    }
}
