using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha15
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentNullException("FirstName cannot be empty.");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentNullException("LastName cannot be empty.");
                }
                lastName = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 120.");
                }
                age = value;
            }
        }
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
