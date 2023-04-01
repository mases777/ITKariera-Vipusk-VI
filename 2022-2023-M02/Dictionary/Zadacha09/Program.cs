using System;
using System.Linq;

namespace Zadacha09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var commands = Console.ReadLine().Split().ToArray();
                if (commands[0] == "stop")
                {
                    break;
                }
                var email = Console.ReadLine();
                var names = (string.Join(" ", commands));
                if (email.Contains("bg") && commands[0] != "stop")
                {
                    Console.WriteLine($"{names} -> {email}");
                }
            }
        }
    }
}
