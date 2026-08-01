using System;
using System.Collections.Generic;
using System.Text;

namespace Key_words_Level_1_Lab_Practice
{
    internal class Employee
    {
        public static string CompanyName = "BridgeLabz";
        private static int totalEmployees = 0;

        public readonly int Id;
        public string Name;
        public string Designation;

        public Employee(int Id, string Name, string Designation)
        {
            this.Id = Id;
            this.Name = Name;
            this.Designation = Designation;
            totalEmployees++;
        }

        public void Display()
        {
            Console.WriteLine("Company Name : " + CompanyName);
            Console.WriteLine("Employee ID : " + Id);
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Designation : " + Designation);
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees : " + totalEmployees);
        }

        public static void display()
        {
            Employee employee = new Employee(101, "Ayush", "Software Engineer");

            if (employee is Employee)
            {
                employee.Display();
            }

            DisplayTotalEmployees();
        }
    }
}
