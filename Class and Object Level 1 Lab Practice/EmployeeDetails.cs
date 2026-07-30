using System;
using System.Collections.Generic;
using System.Text;

namespace Class_and_Object_Level_1_Lab_Practice
{
    internal class EmployeeDetails
    {
        private string name;
        private int id;
        private double salary;
        public EmployeeDetails(string name,int id,double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee ID   : " + id);
            Console.WriteLine("Salary        : " + salary);
        }
    }
}
