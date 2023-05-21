using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam
{
    public class Perfumery
    {
        private string name;
        private List<Perfume> perfumes;

        public Perfumery(string name)
        {
            Name = name;
            perfumes = new List<Perfume>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid perfumery name!");
                }
                name = value;
            }
        }
        public void AddPerfume(Perfume perfume)
        {
            perfumes.Add(perfume);
        }

        public bool SellPerfume(Perfume perfume)
        {
            return perfumes.Remove(perfumes.FirstOrDefault(x => x.Brand == perfume.Brand));
        }

        public double CalculateTotalPrice()
        {
            return perfumes.Sum(x => x.Price);
        }

        public Perfume GetPerfumeWithHighestPrice()
        {
            return perfumes.OrderByDescending(x => x.Price).First();
        }

        public Perfume GetPerfumeWithLowestPrice()
        {
            return perfumes.OrderBy(x => x.Price).First();
        }

        public void RenamePerfumery(string newName)
        {
            Name = newName;
        }

        public void SellAllPerfumes()
        {
            perfumes.Clear();
        }

        public override string ToString()
        {
            if (perfumes.Count == 0)
            {
                return $"Perfumery {Name} has no available perfumes.";
            }

            string result = $"Perfumery {Name} has {perfumes.Count} perfume/s:\n";
            result += string.Join("\n", perfumes);
            return result;
        }
    }
}
