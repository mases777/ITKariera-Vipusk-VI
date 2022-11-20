using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_Exam5_Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            int third = num % 10;
            int second = (num / 10) % 10;
            int first = num / 100;
            int n = first + second;
            int m = first + third;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (num % 5 == 0)                    
                        num -= first;                    
                    else if (num % 3 == 0)                    
                        num -= second;                    
                    else                    
                        num += third;
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
