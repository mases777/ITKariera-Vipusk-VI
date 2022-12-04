using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double catering = rent * 2;
            double beverage = catering - (catering * 0.15);
            double presents = (catering + beverage) / 7;
            double total = rent + catering + beverage + presents;
            Console.WriteLine($"{total:f2}");
        }
    }
}
