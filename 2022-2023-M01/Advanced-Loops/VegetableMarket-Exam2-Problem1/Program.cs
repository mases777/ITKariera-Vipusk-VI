using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket_Exam2_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kgPriceVegetable = double.Parse(Console.ReadLine());
            var kgPriceFruit = double.Parse(Console.ReadLine());
            var totalKgVegetable = int.Parse(Console.ReadLine());
            var totalKgFruit = int.Parse(Console.ReadLine());

            var priceVegetable = kgPriceVegetable * totalKgVegetable;
            var priceFruit = kgPriceFruit * totalKgFruit;
            var price = priceVegetable + priceFruit;
            var priceEuro = price / 1.94;
            Console.WriteLine(priceEuro);

        }
    }
}
