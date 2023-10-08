using System;

namespace Zadacha10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rect = new Rectangle(2.3, 3.1);
            Console.WriteLine(rect.Draw());
            Console.WriteLine($"Area = {rect.calculateArea():f2}");
            Console.WriteLine($"Perimeter = {rect.calculatePerimeter():f2}");

            Shape circle = new Circle(3.1);
            Console.WriteLine(circle.Draw());
            Console.WriteLine($"Area = {circle.calculateArea():f2}");
            Console.WriteLine($"Perimeter = {circle.calculatePerimeter():f2}");
        }
    }
}
