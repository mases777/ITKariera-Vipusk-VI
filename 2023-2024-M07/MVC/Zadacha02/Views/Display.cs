using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha02.Views
{
    public class Display
    {
        public int Kilometers { get; set; }
        public string Time { get; set; }
        public double TotalPrice { get; set; }
        public Display()
        {
            Kilometers = 0;
            Time = "";
            TotalPrice = 0;
            GetValues();
        }

        public void GetValues()
        {
            Console.Write("Enter the kilometers you will travel: ");
            Kilometers = int.Parse(Console.ReadLine());
            Console.Write("Enter the phase of the day you will travel (day/night): ");
            Time = Console.ReadLine();
        }

        public void ShowCheapestWayToTravel()
        {
            Console.WriteLine($"{TotalPrice:f2}");
        }
    }
}
