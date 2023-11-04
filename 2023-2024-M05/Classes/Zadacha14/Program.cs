using System;
using System.Linq;
using System.Threading.Channels;

namespace Zadacha14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split();

            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            words.Where(checker)
                .ToList()
                .ForEach(n => Console.WriteLine(n));

        }
    }
}
