﻿using System;
using System.Linq;

namespace Zadacha07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();

            var parts = email.Split('@').ToArray();
            var part1 = parts[0];
            var part2 = parts[1];

            int sum1 = 0, sum2 = 0;
            foreach (var item in part1)
            {
                sum1++;
                //sum1 += (int)item;
            }
            foreach (var item in part2)
            {
                sum2++;
                //sum2 += (int)item;
            }
            if (sum1 >= sum2)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }

        }
    }
}
