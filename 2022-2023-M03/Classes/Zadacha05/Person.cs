using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha05
{
    public class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }
                firstName = value;
            }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }
                lastName = value;
            }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                age = value;
            }
        }
        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
                salary = value;
            }
        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            this.Age = age;
        }

        public Person(string firstName, string lastName, int age, double salary) : this(firstName, lastName, age)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} get {this.Salary:f2} leva";
        }
    }
}
