using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom_Exam5_Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;            
            if (month == "May" || month == "October")
            {
                apartmentPrice = 65;
                studioPrice = 50;
            }
            else if (month == "June" || month == "September")
            {
                apartmentPrice = 68.7;
                studioPrice = 75.2;
            }
            else
            {
                apartmentPrice = 77;
                studioPrice = 76;
            }
            if (nights > 14)
            {
                apartmentPrice *= 0.9;
                if (month == "June" || month == "September")
                {
                    studioPrice *= 0.8;
                }
                else if (month == "May" || month == "October")
                {
                    studioPrice *= 0.7;
                }
            }
            else if (nights > 7 && (month == "May" || month == "October"))
            {
                studioPrice *= 0.95;
            }
            var resultApartment = apartmentPrice * nights;
            var resultStudio = studioPrice * nights;

            Console.WriteLine($"Apartment: {resultApartment:f2} lv.");
            Console.WriteLine($"Studio: {resultStudio:f2} lv.");

        }
    }
}
