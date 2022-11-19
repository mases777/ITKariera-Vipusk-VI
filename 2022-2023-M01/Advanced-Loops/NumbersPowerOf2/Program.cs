using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersPowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int a = 1;
            Console.WriteLine(a);
            for (int i = 1; i <= n; i++)
            {
                a *= 2;
                Console.WriteLine(a);
            }


            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine(Math.Pow(2, i));
            //}

        }
    }
}
