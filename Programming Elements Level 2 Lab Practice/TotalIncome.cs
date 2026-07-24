using System;
using System.Collections.Generic;
using System.Text;
namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class TotalIncome
    {
        public static void display()
        {
            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Bonus: ");
            double bonus = double.Parse(Console.ReadLine());

            double totalIncome = salary + bonus;

            Console.WriteLine("The salary is INR " + salary +
                              " and bonus is INR " + bonus +
                              ". Hence Total Income is INR " + totalIncome);
        }
    }
}
