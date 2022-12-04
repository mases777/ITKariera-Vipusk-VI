using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nights = int.Parse(Console.ReadLine());
            var destination = Console.ReadLine();
            var typeRoom = Console.ReadLine();
            var total = 0.0;

            if (typeRoom == "double room")
            {
                if (destination == "Colorado")
                {
                    total = 38 * nights;
                }
                else if (destination == "Alps")
                {
                    total = 35 * nights;
                }
                else
                {
                    total = 39 * nights;
                }
            }
            else
            {
                if (destination == "Colorado")
                {
                    total = 45 * nights;
                }
                else if (destination == "Alps")
                {
                    total = 42 * nights;
                }
                else
                {
                    total = 49 * nights;
                }
            }
            Console.WriteLine($"They have to spend {total:f2} leva.");
        }
    }
}
