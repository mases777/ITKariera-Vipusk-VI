using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    class FlowerStore
    {
        private string name;
        private List<Flower> flowers;
        public FlowerStore(string name)
        {
            this.Name = name;
            this.flowers = new List<Flower>();
        }
        public string Name
        {
            get { return name; }
            set {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid flower store name!");
                }
                name = value; }
        }


        public void AddFlower(Flower flower)
        {
            flowers.Add(flower);
        }

        public bool SellFlower(Flower flower)
        {
            Flower flowerToRemove = flowers.FirstOrDefault(x => x.Type == flower.Type);
            return flowers.Remove(flowerToRemove);
        }

        public double CalculateTotalPrice()
        {
            return flowers.Sum(x => x.Price);
        }

        public Flower GetFlowerWithHighestPrice()
        {
            return flowers.OrderByDescending(x => x.Price).First();
        }

        public Flower GetFlowerWithLowestPrice()
        {
            return flowers.OrderBy(x => x.Price).First();
        }

        public void RenameFlowerStore(string newName)
        {
            this.Name = newName;
        }

        public void SellAllFlowers()
        {
            flowers.Clear();
        }

        public override string ToString()
        {
            if (flowers.Count == 0)
            {
                return $"Flower store {this.Name} has no available flowers.";
            }
            string result = $"Flower store {this.Name} has {this.flowers.Count} flower/s:\n";
            result += string.Join("\n", flowers);

            return result;
        }
    }
}