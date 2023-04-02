using System;
using System.Linq;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', ' ' };
            var patients = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "END OF PATIENTS")
            {
                switch (input)
                {
                    case "Add patient":
                        string patient = Console.ReadLine();
                        patients.Add(patient);
                        break;
                    case "Add patient on position":
                        string patient2 = Console.ReadLine();
                        int position = int.Parse(Console.ReadLine());
                        patients.Insert(position, patient2);
                        break;
                    case "Remove patient on position":
                        int position3 = int.Parse(Console.ReadLine());
                        patients.RemoveAt(position3);
                        break;
                    case "Remove last patient":
                        patients.RemoveAt(patients.Count - 1);
                        break;
                    case "Remove first patient":
                        patients.RemoveAt(0);
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", patients));

        }
    }
}
