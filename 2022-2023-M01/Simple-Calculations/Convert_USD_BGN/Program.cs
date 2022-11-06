using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_USD_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dolars = double.Parse(Console.ReadLine());

            var leva = dolars * 1.79549;

            Console.WriteLine($"{leva:f2} BGN");

        }
    }
}
