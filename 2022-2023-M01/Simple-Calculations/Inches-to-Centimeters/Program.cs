﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());

            var centimeters = inches * 2.54;

            Console.WriteLine(centimeters);

        }
    }
}
