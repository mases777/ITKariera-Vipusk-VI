using System;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                var type = Console.ReadLine();
                switch (type)
                {
                    case "computer":
                        sum += 5899; break;
                    case "chair":
                        sum += 1699; break;
                    case "desk":
                        sum += 1789; break;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
