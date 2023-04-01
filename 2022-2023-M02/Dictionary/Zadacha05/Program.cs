using System;
using System.Linq;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[]
            {
                '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '
            };

            var input = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToList();

            var output = input.Where(x => x.Length < 5)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(String.Join(", ", output));

        }
    }
}
