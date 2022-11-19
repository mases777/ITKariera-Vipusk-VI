using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice_Exam1_Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var period = Console.ReadLine();
            double price = 0;
            if (n < 20)
            {
                price += 0.7;
                if (period == "day")
                {
                    price += n * 0.79;
                }
                else
                {
                    price += n * 0.9;
                }
            }
            else if (n < 100)            
                price += n * 0.09;            
            else            
                price += n * 0.06;            
            Console.WriteLine(price);
        }
    }
}
