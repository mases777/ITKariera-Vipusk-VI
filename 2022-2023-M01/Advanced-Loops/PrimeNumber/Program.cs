﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var prime = true;
            if (n <= 1) prime = false;
            for (var i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            if (prime) Console.WriteLine("Prime");
            else Console.WriteLine("Not prime");
        }
    }
}
