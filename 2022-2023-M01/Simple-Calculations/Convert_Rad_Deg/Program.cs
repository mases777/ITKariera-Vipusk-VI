using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Rad_Deg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var radian = double.Parse(Console.ReadLine());

            var celsium = Math.Round(radian * 180 / Math.PI);

            Console.WriteLine(celsium);

        }
    }
}
