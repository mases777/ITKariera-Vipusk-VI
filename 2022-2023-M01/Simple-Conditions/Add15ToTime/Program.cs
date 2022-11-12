using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add15ToTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            var minutes = h * 60 + m;
            minutes += 15;

            var hour = minutes / 60;
            var min = minutes % 60;

            if (hour > 23)
            {
                hour = hour % 24;
            }
            Console.Write(hour + ":");
            if (min < 10)
            {
                Console.WriteLine("0" + min);
                //Console.WriteLine($"0{min}");
            }
            else
            {
                Console.WriteLine(min);
            }







            //minutes = minutes + 15;
            //minutes += 15;

            //minutes++;
            //minutes = minutes + 1;
            //minutes += 1;
            //minutes -= -1;

        }
    }
}
