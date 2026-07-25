using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class EmployeeBonusCalculator
    {
        public static void display()
        {
            Console.Write("Enter the Salary of The Employee : ");
            int salary = int.Parse(Console.ReadLine());

            Console.Write("Enter the Service Year of The Employee : ");
            int service = int.Parse(Console.ReadLine());

            if (service <= 5)
            {
                Console.WriteLine($"The service is not more then 5 years their is no bonus, The Salry to be given : {salary}");
            }
            else
            {
                Console.WriteLine($"The Bonus Amount is {(salary*.05)} and the total salary to be paid is {salary+(salary*0.05)}");
            }
        }
    }
}
