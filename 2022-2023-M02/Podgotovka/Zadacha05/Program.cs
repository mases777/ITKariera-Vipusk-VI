using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());
            int red = 0, blue = 0, orange = 0, green = 0;

            for (int i = 0; i < eggsCount; i++)
            {
                var eggsCollor = Console.ReadLine();
                switch (eggsCollor)
                {
                    case "red": red++; break;
                    case "orange": orange++; break;
                    case "blue": blue++; break;
                    case "green": green++; break;
                }
            }

            int max = red;
            string maxCollor = "red";

            if (orange > max)
            {
                max = orange;
                maxCollor = "orange";
            }
            if (blue > max)
            {
                max = blue;
                maxCollor = "blue";
            }
            if (green > max)
            {
                max = green;
                maxCollor = "green";
            }
            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {max} -> {maxCollor}");


            //int eggsCount = int.Parse(Console.ReadLine());
            //var eggs = new Dictionary<string, int>();
            //for (int i = 0; i < eggsCount; i++)
            //{
            //    var eggsCollor = Console.ReadLine();
            //    if (eggs.ContainsKey(eggsCollor))
            //    {
            //        eggs[eggsCollor] += 1;
            //    }
            //    else
            //    {
            //        eggs[eggsCollor] = 1;
            //    }
            //}
            //Console.WriteLine($"Red eggs: {eggs
            //    .Where(x => x.Key == "red").Max(y => y.Value)}");

        }
    }
}
