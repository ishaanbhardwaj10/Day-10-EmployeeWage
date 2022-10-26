﻿using System;

namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Use Case #9: Compute and Save Total Employee Wage for Multiple Companies");
            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 9:
                    EmpBuilderObject flipkart = new EmpBuilderObject("Flipkart", 20, 10, 60);
                    EmpBuilderObject amazon = new EmpBuilderObject("Amazon", 20, 15, 80);
                    flipkart.CalculateMonthlyWage();
                    Console.WriteLine(flipkart.ToString());
                    amazon.CalculateMonthlyWage();
                    Console.WriteLine(amazon.ToString());
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }
        }
    }
}