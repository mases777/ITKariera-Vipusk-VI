﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RegularExam
{
    public class Perfume
    {

        private string brand;
        private double price;
        public Perfume(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 100)
                {
                    throw new ArgumentException("Invalid perfume price!");
                }
                price = value;
            }
        }
        public override string ToString()
        {
            return $"Perfume {Brand} costs {Price:f2}";
        }
    }
}
