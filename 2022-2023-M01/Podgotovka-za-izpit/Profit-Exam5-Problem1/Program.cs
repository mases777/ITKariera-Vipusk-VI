using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_Exam5_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            var moneysPerDay = double.Parse(Console.ReadLine());
            var dolarsLeva = double.Parse(Console.ReadLine());

            var monthSalary = days * moneysPerDay;
            var yearsMoney = monthSalary * 14.5;
            var tax = yearsMoney * 0.25;
            var dohod = (yearsMoney - tax) * dolarsLeva;
            var result = dohod / 365;

            Console.WriteLine($"{result:f2}");

        }
    }
}
