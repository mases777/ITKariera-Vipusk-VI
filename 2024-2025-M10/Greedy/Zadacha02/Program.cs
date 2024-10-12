using System;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дроб:  7/9
            int p = 7, q = 9, r = 0;

            while (p > 1)
            {
                r = (p + q) / p;   // r=(7+9)/7 = 2
                Console.Write($"1/{r} + ");

                p = p * r - q;  // p = 7*2-9 = 5
                q = q * r;      // q = 9*2 = 18

                int m = GCD(p, q);
                p = p / m;
                q = q / m;
            }
            Console.WriteLine($"1/{q}");

        }

        private static int GCD(int a, int b)
        {
            if (a > b) return GCD(a - b, b);
            else if (b > a) return GCD(a, b - a);
            return a;        
        }

    }
}
