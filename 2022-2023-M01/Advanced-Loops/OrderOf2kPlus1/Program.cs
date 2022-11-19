using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOf2kPlus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = 1;
            while (n >= num)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }

        }
    }
}
