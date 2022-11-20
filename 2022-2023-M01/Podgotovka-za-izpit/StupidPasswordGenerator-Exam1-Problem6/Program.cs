using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator_Exam1_Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int a = 1; a <= first; a++)
                for (int b = 1; b <= first; b++)
                    for (char c = 'a'; c < 'a' + second; c++)
                        for (char d = 'a'; d < 'a' + second; d++)
                            for (int e = 1; e <= first; e++)
                            {
                                if (e > a && e > b)
                                {
                                    Console.Write($"{a}{b}{c}{d}{e} ");
                                }                                
                            }
            Console.WriteLine();
        }
    }
}
