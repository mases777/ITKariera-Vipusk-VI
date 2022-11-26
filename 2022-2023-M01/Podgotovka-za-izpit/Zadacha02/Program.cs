using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var firstPresent = double.Parse(Console.ReadLine());

            var secondPresent = 0.2 * firstPresent;
            var thirdPresent = 0.7 * secondPresent;
            var fourthPresent = 0.5 * secondPresent;
            var total = firstPresent + secondPresent + thirdPresent + fourthPresent;

            if (budget >= total)
            {
                Console.WriteLine($"Yes! {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No! {total - budget:f2} leva needed.");
            }

        }
    }
}
