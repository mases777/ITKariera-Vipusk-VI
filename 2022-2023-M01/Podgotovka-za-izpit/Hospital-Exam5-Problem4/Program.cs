using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Exam5_Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int count = 1;
            int treated = 0;
            int untreated = 0;
            for (int i = 0; i < period; i++)
            {
                if (count % 3 == 0 && untreated > treated)
                    doctors++;
                var patient = int.Parse(Console.ReadLine());
                if (patient > doctors)
                {
                    treated += doctors;
                    untreated += patient - doctors;
                }
                else                
                    treated += patient;                
                count++;
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
