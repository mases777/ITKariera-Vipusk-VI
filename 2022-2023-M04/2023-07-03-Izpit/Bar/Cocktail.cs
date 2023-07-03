using System;
using System.Collections.Generic;
using System.Text;

namespace UASD_Retake
{
    public class Cocktail
    {
        private string name;
        private double price;

        public Cocktail() { }

        public Cocktail(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return $"Cocktail {Name} costs {Price:f2} lv.";
        }
    }
}
