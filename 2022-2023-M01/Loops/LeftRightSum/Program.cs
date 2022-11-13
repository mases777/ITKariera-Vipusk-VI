using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                rightSum += num;
            }
            if (Math.Abs(leftSum - rightSum) == 0)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }

        }
    }
}
