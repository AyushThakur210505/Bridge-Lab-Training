using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }

    class Developer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Developer is writing code.");
        }
    }

    public class InheritanceTesting
    {
        public static void Run()
        {
            Console.WriteLine("=== Inheritance Testing ===");

            Employee employee = new Employee();
            Employee developer = new Developer();

            employee.Work();
            developer.Work();
        }
    }
}
