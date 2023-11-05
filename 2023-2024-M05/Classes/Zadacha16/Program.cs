using System;
using System.IO;

namespace Zadacha16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("F:\\repos\\ITKariera-Vipusk-VI\\2023-2024-M05\\Classes\\Zadacha16\\text.txt");
            using (reader)
            {
                int counter = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (counter % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                    line = reader.ReadLine();
                }
                reader.Close();
            }

        }
    }
}
