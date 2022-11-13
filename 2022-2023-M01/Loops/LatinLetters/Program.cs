using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Latin alphabet: ");
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
