using System;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = "";
            string letters = "";
            string otherChars = "";
            foreach (char item in input)
            {
                if (Char.IsDigit(item))
                {
                    digits += item;
                }
                else if (Char.IsLetter(item))
                {
                    letters += item;
                }
                else
                {
                    otherChars += item;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}
