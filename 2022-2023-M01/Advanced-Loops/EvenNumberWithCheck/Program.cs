﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumberWithCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                try
                {
                   n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    throw;
                }
                if (n % 2 == 0)
                {
                    Console.WriteLine(n); break;
                }
            }

        }
    }
}
