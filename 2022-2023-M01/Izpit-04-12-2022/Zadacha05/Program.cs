using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            for (int a = 0; a <= 9; a++)
                for (int b = 0; b <= 9; b++)
                    for (int c = 0; c <= 8; c += 2)
                        for (int d = 0; d <= 9; d += 9)
                            for (int e = 3; e <= 6; e += 3)
                            {
                                if (a + b == n)
                                {
                                    Console.Write($"{a}{b}{c}{d}{e} ");
                                    br++;
                                }
                            }
            Console.WriteLine($"Count of winner numbers: {br}");
        }
    }
}
