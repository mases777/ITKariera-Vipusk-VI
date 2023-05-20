using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToArray();
                var person = new Person(
                    line[0],
                    line[1],
                    int.Parse(line[2]),
                    double.Parse(line[3])
                    );
                persons.Add(person);
            }

            persons.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
