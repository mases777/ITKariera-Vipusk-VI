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
            var oneBanichka = double.Parse(Console.ReadLine());
            var allBanichki = int.Parse(Console.ReadLine());
            var allMekitsi = int.Parse(Console.ReadLine());
            var allKifli = int.Parse(Console.ReadLine());
            var allGevretsi = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var oneMekitsa = oneBanichka * 1.2;
            var oneKifla = oneMekitsa * 0.6;
            var oneGevrek = 1.20 + oneKifla;

            var total = oneBanichka * allBanichki + oneMekitsa * allMekitsi + oneKifla * allKifli + oneGevrek * allGevretsi;
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
