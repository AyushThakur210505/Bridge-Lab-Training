using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers_Practice_Problem
{
    internal class Employee
    {
        public int employeeID;
        protected string department;
        private double salary;

        public void SetDetails(int id, string dept, double empSalary)
        {
            employeeID = id;
            department = dept;
            salary = empSalary;
        }

        public void SetSalary(double empSalary)
        {
            salary = empSalary;
        }

        public double GetSalary()
        {
            return salary;
        }
    }

    internal class Manager : Employee
    {
        public void Display()
        {
            Console.WriteLine("Employee ID : " + employeeID);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("Salary : " + GetSalary());
        }
    }
}
