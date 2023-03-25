using System;
using System.Collections.Generic;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ore = new Dictionary<string, int>();
            var resource = Console.ReadLine();
            while (resource != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (ore.ContainsKey(resource))
                {
                    ore[resource] += quantity;
                }
                else
                {
                    ore[resource] = quantity;
                }
                resource = Console.ReadLine();
            }

            foreach (var item in ore)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
