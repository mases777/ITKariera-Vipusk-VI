using System;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList<int>();
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            list.Add(5);
            list.Add(6);
            list.Add(7);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            Console.WriteLine(list[1]);
            Console.WriteLine(list.RemoveAt(2));
            Console.WriteLine(list.RemoveAt(0));
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
        }
    }
}
