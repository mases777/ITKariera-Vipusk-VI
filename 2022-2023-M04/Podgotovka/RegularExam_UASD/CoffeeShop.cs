using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam_UASD
{
    public class CoffeeShop
    {
        private string name;
        private List<Coffee> coffees;

        public CoffeeShop() { }

        public CoffeeShop(string name)
        {
            Name = name;
            Coffees = new List<Coffee>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Coffee> Coffees
        {
            get { return coffees; }
            set { coffees = value; }
        }
        public void AddCoffee(string type, double price)
        {
            Coffee coffee = new Coffee(type, price);
            coffees.Add(coffee);
        }

        public double AveragePriceInRange(double start, double end)
        {
            var average = coffees.Where(x => x.Price >= start && x.Price <= end)
                .Select(x => x.Price).Average();
            return average;
        }

        public List<string> FilterCoffeesByPrice(double price)
        {
            return coffees.Where(x => x.Price < price).Select(x => x.Type).ToList();
        }

        public List<Coffee> SortAscendingByType()
        {
            coffees = coffees.OrderBy(x => x.Type).ToList();
            return coffees;
        }

        public List<Coffee> SortDescendingByPrice()
        {
            coffees = coffees.OrderByDescending(x => x.Price).ToList();
            return coffees;
        }

        public bool CheckCoffeeIsInCoffeeShop(string type)
        {
            foreach (var item in coffees)
            {
                if (item.Type == type)
                {
                    return true;
                }
            }
            return false;
        }

        public string[] ProvideInformationAboutAllCoffees()
        {
            return coffees.Select(x => x.ToString()).ToArray();
        }
    }
}
