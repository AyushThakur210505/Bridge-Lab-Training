using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Level_2_Lab_Practice
{
    internal class EmployeeBonusCalculator
    {
        public static void display()
        {
            double[] salary = new double[10];
            double[] year = new double[10];
            double[] bonus = new double[10];
            double[] newSalary = new double[10];

            double totalBonus = 0;
            double totalSalary = 0;
            double totalNewSalary = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Employee " + (i + 1));

                Console.Write("Enter Salary : ");
                salary[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter Years of Service : ");
                year[i] = double.Parse(Console.ReadLine());

                if (salary[i] <= 0 || year[i] < 0)
                {
                    Console.WriteLine("Invalid Input");
                    i--;
                }
            }


            for (int i = 0; i < 10; i++)
            {
                if (year[i] > 5)
                {
                    bonus[i] = salary[i] * 5 / 100;
                }
                else
                {
                    bonus[i] = salary[i] * 2 / 100;
                }

                newSalary[i] = salary[i] + bonus[i];

                totalBonus += bonus[i];
                totalSalary += salary[i];
                totalNewSalary += newSalary[i];

                Console.WriteLine((i + 1) + "\t" + salary[i] + "\t" + bonus[i] + "\t" + newSalary[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Total Salary = " + totalSalary);
            Console.WriteLine("Total Bonus = " + totalBonus);
            Console.WriteLine("Total New Salary = " + totalNewSalary);
        }
    }
}