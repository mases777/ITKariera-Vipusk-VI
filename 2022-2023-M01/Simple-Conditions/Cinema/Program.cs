using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var total = 0.0;

            if (projection == "Premiere")
            {
                total = r * c * 12;
            }
            else if (projection == "Normal")
            {
                total = r * c * 7.5;
            }
            else
            {
                total = r * c * 5;
            }
            Console.WriteLine($"{total:f2} leva");
        }
    }
}
