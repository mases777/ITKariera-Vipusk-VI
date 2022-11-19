using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int f0 = 1, f1 = 1;            
            for (int i = 0; i < n-1; i++)
            {
                int sum = f0 + f1;
                f0 = f1;
                f1 = sum;
            }
            Console.WriteLine(f1);
        }
    }
}
