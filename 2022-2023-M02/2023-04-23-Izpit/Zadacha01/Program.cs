using System;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                string type = Console.ReadLine();
                switch (type)
                {
                    case "microscope": sum += 6000; break;
                    case "scalpel": sum += 1500; break;
                    case "syringe": sum += 100; break;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
