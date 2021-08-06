﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers

            Console.WriteLine("This is the sum of all the numbers => ");
            Console.WriteLine(numbers.Sum(x => x));
            Console.WriteLine();

            Console.WriteLine("This is the adverage of all the numbers => ");
            Console.WriteLine(numbers.Average(x => x));
            Console.WriteLine();


            //Order numbers in ascending order and decsending order. Print each to console.

            Console.WriteLine("This is the asending order of all the numbers => ");

            var asendOrder = numbers.OrderBy(x => x);

            //Loging each item to the console
            foreach (var item in asendOrder)
            {
                Console.WriteLine(item);
            }

            
           


            Console.WriteLine("This is the desending order of all the numbers => ");

            /* var descendOrder = numbers.OrderByDescending(x => x);

             //Loging each item to the console
             foreach (var item in descendOrder)
             {
                 Console.WriteLine(item);
             }*/

            //Print to the console only the numbers greater than 6

            var greater = numbers.Where(x => x > 6);
            Console.WriteLine(greater);

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            foreach (var item in asendOrder.Take(4)) //this limits to 4 numbers
            {
                Console.WriteLine(item);
            }

            //Change the value at index 4 to your age, then print the numbers in decsending order
            numbers.SetValue(38, 4);
            var desendWithAge = numbers.OrderByDescending(x => x);
            foreach (var item in desendWithAge)
            {
                Console.WriteLine(item);
            }

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.

            var byName = employees.FindAll(x => x.FirstName.ToLower()[0] == 'c' || x.FirstName.ToLower()[0] == 'c');

            foreach (var item in byName)
            {
                Console.WriteLine(item);
            }


            //Print all the employees' FullName and Age who are over the age 26 to the console.
           //Order this by Age first and then by FirstName in the same result.

            var twentySix = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);
            Console.WriteLine("Over 26");
            foreach (var item in twentySix)
            {
                Console.WriteLine(item);
            }


            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35

            var sumAndYears = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);


            //Add an employee to the end of the list without using employees.Add()

            IEnumerable<Employee> enumerable = employees.Append(new Employee("Deontay"));
           
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
