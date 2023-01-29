using System;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int water = 0;
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                water += input;
                if (water > 255)
                {
                    water -= input;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(water);
        }
    }
}
