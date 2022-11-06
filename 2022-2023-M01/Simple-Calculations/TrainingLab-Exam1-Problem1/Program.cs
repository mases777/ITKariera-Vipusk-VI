using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab_Exam1_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine()) * 100;
            var w = double.Parse(Console.ReadLine()) * 100;

            var row = (int)(h / 120);
            var col = (int)((w - 100) / 70);            

            Console.WriteLine(row * col - 3);
        }
    }
}
