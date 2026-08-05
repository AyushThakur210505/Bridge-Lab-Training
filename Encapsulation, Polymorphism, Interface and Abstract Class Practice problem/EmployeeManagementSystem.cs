using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation__Polymorphism__Interface_and_Abstract_Class_Practice_problem
{
    interface IDepartment
    {
        void AssignDepartment(string department);
        void GetDepartmentDetails();
    }

    abstract class Employee
    {
        private int employeeId;
        private string name;
        private double baseSalary;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public Employee(int id, string name, double salary)
        {
            EmployeeId = id;
            Name = name;
            BaseSalary = salary;
        }

        public abstract double CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID : " + EmployeeId);
            Console.WriteLine("Name        : " + Name);
            Console.WriteLine("Base Salary : " + BaseSalary);
            Console.WriteLine("Final Salary: " + CalculateSalary());
        }
    }

    class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        public FullTimeEmployee(int id, string name, double salary)
            : base(id, name, salary)
        {
        }

        public override double CalculateSalary()
        {
            return BaseSalary;
        }

        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public void GetDepartmentDetails()
        {
            Console.WriteLine("Department  : " + department);
        }
    }

    class PartTimeEmployee : Employee, IDepartment
    {
        private string department;
        private int workHours;
        private double hourlyRate;

        public PartTimeEmployee(int id, string name, double salary, int hours, double rate)
            : base(id, name, salary)
        {
            workHours = hours;
            hourlyRate = rate;
        }

        public override double CalculateSalary()
        {
            return workHours * hourlyRate;
        }

        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public void GetDepartmentDetails()
        {
            Console.WriteLine("Department  : " + department);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            FullTimeEmployee emp1 = new FullTimeEmployee(101, "Ali", 50000);
            emp1.AssignDepartment("IT");

            PartTimeEmployee emp2 = new PartTimeEmployee(102, "Sara", 0, 80, 300);
            emp2.AssignDepartment("HR");

            employees.Add(emp1);
            employees.Add(emp2);

            Console.WriteLine("===== Employee Management System =====\n");

            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();

                if (emp is IDepartment dept)
                {
                    dept.GetDepartmentDetails();
                }

                Console.WriteLine("-------------------------------");
            }

            Console.ReadKey();
        }
    }
}
