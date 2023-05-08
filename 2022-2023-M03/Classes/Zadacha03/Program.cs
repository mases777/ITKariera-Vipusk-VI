﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split().ToArray();
                int age = -1;
                string email = "n/a";
                if (line.Count() == 6)
                {
                    email = line[4];
                    age = int.Parse(line[5]);
                }
                else if (line.Count() > 4)
                {
                    if (!int.TryParse(line[4], out age))
                    {
                        age = -1;
                        if (!string.IsNullOrEmpty(line[4]))
                            email = line[4];
                    }
                }

                employees.Add
                    (
                    new Employee()
                        {
                            Name = line[0],
                            Salary = double.Parse(line[1]),
                            Position = line[2],
                            Department = line[3],
                            Email = email,
                            Age = age
                        }
                    );
            }

            Dictionary<string, List<double>> departmentPartitioning = new Dictionary<string, List<double>>();
            foreach (var item in employees)
            {
                if (!departmentPartitioning.ContainsKey(item.Department))
                {
                    departmentPartitioning[item.Department] = new List<double>();
                }
                departmentPartitioning[item.Department].Add(item.Salary);
            }

            Dictionary<string, double> averageSalaryByDepartments = new Dictionary<string, double>();
            foreach (var item in departmentPartitioning.Keys)
            {
                averageSalaryByDepartments[item] = departmentPartitioning[item].Average();
            }

            var maxAverageSalaryDepartment = averageSalaryByDepartments
                .OrderByDescending(x => x.Value).First();
            Console.WriteLine($"Highest Average Salary: {maxAverageSalaryDepartment.Key}");

            employees = employees
                .OrderByDescending(x => x.Salary).ToList();

            foreach (var item in employees)
            {
                if (item.Department == maxAverageSalaryDepartment.Key)
                {
                    Console.WriteLine($"{item.Name} {item.Salary:f2} {item.Email} {item.Age}");
                }
            }
               

        }
    }
}
