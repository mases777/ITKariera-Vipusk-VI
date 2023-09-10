using System;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var box1 = new Box<int>();
            box1.Add(123);
            Console.WriteLine(box1.ToString());

            var box2 = new Box<string>();
            box2.Add("life in a box");
            Console.WriteLine(box2.ToString());

            var box3 = new Box<double>();
            box3.Add(3.14);
            Console.WriteLine(box3.ToString());
        }
    }
}
