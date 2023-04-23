using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] splitOn = new char[] { ' ', ',' };

            List<string> owners = Console.ReadLine()
                .Split(splitOn, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "END OF OWNERS")
            {
                switch (input)
                {
                    case "Add owner":
                        AddOwner(owners);
                        break;
                    case "Add owner on position":
                        AddOwnerOnPosition(owners);
                        break;
                    case "Remove owner on position":
                        RemoveOwnerOnPosition(owners);
                        break;
                    case "Remove last owner":
                        RemoveLastOwner(owners);
                        break;
                    case "Remove first owner":
                        RemoveFirstOwner(owners);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", owners));
        }
        static void RemoveFirstOwner(List<string> owners)
        {
            owners.RemoveAt(0);
        }

        static void RemoveLastOwner(List<string> owners)
        {
            owners.RemoveAt(owners.Count - 1);
        }

        static void RemoveOwnerOnPosition(List<string> owners)
        {
            byte position = byte.Parse(Console.ReadLine());

            owners.RemoveAt(position);
        }

        static void AddOwnerOnPosition(List<string> owners)
        {
            string newOwner = Console.ReadLine();
            byte position = byte.Parse(Console.ReadLine());

            owners.Insert(position, newOwner);
        }

        static void AddOwner(List<string> owners)
        {
            string newOwner = Console.ReadLine();

            owners.Add(newOwner);
        }
    }
}
