﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());

            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");

        }
    }
}
