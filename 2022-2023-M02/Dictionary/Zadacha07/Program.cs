using System;
using System.Linq;

namespace Zadacha07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine()
                .Split()
                .Select(x => DateTime.ParseExact(x, "HH:mm", null))
                .ToList()
                .OrderBy(x => x);

            Console.WriteLine(String.Join(", ", times.Select(x => x.ToString("HH:mm")).ToArray()));

        }
    }
}
