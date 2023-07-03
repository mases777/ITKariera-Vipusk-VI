using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UASD_Retake
{
    public class Bar
    {
        private string name;
        private List<Cocktail> cocktails;

        public Bar() { }

        public Bar(string name)
        {
            Name = name;
            Cocktails = new List<Cocktail>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Cocktail> Cocktails
        {
            get { return cocktails; }
            set { cocktails = value; }
        }
        public void AddCocktail(string name, double price)
        {
            Cocktail cocktail = new Cocktail(name, price);
            cocktails.Add(cocktail);
        }

        public double AveragePriceInRange(double start, double end)
        {
            var average = cocktails.Where(x => x.Price >= start && x.Price <= end)
                .Select(x => x.Price).Average();
            return average;
        }

        public List<string> FilterCocktailsByPrice(double price)
        {
            return cocktails.Where(x => x.Price < price).Select(x => x.Name).ToList();
        }

        public List<Cocktail> SortAscendingByName()
        {
            cocktails = cocktails.OrderBy(x => x.Name).ToList();
            return cocktails;
        }

        public List<Cocktail> SortDescendingByPrice()
        {
            cocktails = cocktails.OrderByDescending(x => x.Price).ToList();
            return cocktails;
        }

        public bool CheckCocktailIsInBar(string name)
        {
            foreach (var item in cocktails)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public string[] ProvideInformationAboutAllCocktails()
        {
            return cocktails.Select(x => x.ToString()).ToArray();
        }
    }
}
