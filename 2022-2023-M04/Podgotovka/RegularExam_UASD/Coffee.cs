﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RegularExam_UASD
{
    public class Coffee
    {
        private string type;
        private double price;

        public Coffee() { }

        public Coffee(string type, double price)
        {
            this.Type = type;
            this.Price = price;
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return $"Coffee {Type} costs {Price:f2} lv.";
        }

    }
}
