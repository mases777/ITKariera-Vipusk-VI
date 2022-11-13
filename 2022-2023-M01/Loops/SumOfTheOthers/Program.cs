using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTheOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;                    
                }
            }
            sum -= max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sum - max));
            }
        }
    }
}
