using System;

namespace Zadacha06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var banWord = Console.ReadLine().Split();
            var text = Console.ReadLine();

            foreach (var item in banWord)
            {
                if (text.Contains(item))
                {
                    text = text.Replace(item, new string('*', item.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
