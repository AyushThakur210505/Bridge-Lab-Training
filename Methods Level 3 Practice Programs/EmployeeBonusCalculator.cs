using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class EmployeeBonusCalculator
    {
        public static void display()
        {
            double[,] employees = GenerateEmployeeData();
            double[,] result = CalculateBonus(employees);

            double oldSalaryTotal = 0;
            double newSalaryTotal = 0;
            double bonusTotal = 0;

            Console.WriteLine("Emp\tOld Salary\tYears\tBonus\t\tNew Salary");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}\t{employees[i, 0]:F2}\t\t{employees[i, 1]}\t{result[i, 1]:F2}\t\t{result[i, 0]:F2}");

                oldSalaryTotal += employees[i, 0];
                newSalaryTotal += result[i, 0];
                bonusTotal += result[i, 1];
            }

            Console.WriteLine("\nTotal Old Salary : " + oldSalaryTotal.ToString("F2"));
            Console.WriteLine("Total Bonus : " + bonusTotal.ToString("F2"));
            Console.WriteLine("Total New Salary : " + newSalaryTotal.ToString("F2"));
        }

        public static double[,] GenerateEmployeeData()
        {
            Random random = new Random();
            double[,] employees = new double[10, 2];

            for (int i = 0; i < 10; i++)
            {
                employees[i, 0] = random.Next(10000, 100000);
                employees[i, 1] = random.Next(1, 11);
            }

            return employees;
        }

        public static double[,] CalculateBonus(double[,] employees)
        {
            double[,] result = new double[10, 2];

            for (int i = 0; i < 10; i++)
            {
                double salary = employees[i, 0];
                double years = employees[i, 1];

                double bonus = years > 5 ? salary * 0.05 : salary * 0.02;

                result[i, 0] = salary + bonus;
                result[i, 1] = bonus;
            }

            return result;
        }
    }
}