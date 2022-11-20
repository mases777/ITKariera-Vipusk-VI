using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm_Exam5_Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var persons = int.Parse(Console.ReadLine());

            var hoursWork = days * 0.9 * 8;
            var extraTime = persons * 2 * days;
            var totalHours = (int)Math.Floor(hoursWork + extraTime);
            if (totalHours >= neededHours)
            {
                Console.WriteLine($"Yes!{totalHours - neededHours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{neededHours - totalHours} hours needed.");
            }

        }
    }
}
