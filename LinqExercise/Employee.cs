using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{
    internal class Employee
    {
        private string v;

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int YearsOfExperience { get; set; }

        public Employee(string firstName, string lastName, int age, int yearsOfExperience)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            YearsOfExperience = yearsOfExperience;
        }
        
        public Employee()
        {
            
        }

        public Employee(string v)
        {
            this.v = v;
        }
    }
}
