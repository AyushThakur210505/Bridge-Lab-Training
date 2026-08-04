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

    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is managing the team.");
        }
    }

    public class MethodOverride
    {
        public static void Run()
        {
            Console.WriteLine("=== Method Override ===");

            Employee employee = new Manager();
            employee.Work();
        }
    }
}
