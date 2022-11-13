using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            double a = 0, b = 0, area = 0;
            switch (figure)
            {
                case "square":
                    a = double.Parse(Console.ReadLine());
                    area = a * a; break;
                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    area = a * b; break;
                case "circle":
                    a = double.Parse(Console.ReadLine());
                    area = Math.PI * a * a; break;
                case "triangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    area = a * b / 2; break;                
            }
            Console.WriteLine($"{Math.Round(area, 3)}");

        }
    }
}
