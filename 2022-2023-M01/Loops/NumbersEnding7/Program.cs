using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEnding7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();



            for (int i = 7; i <= 1000; i += 10)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
