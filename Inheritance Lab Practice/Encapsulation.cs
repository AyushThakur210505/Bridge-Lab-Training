using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Student : Person
    {
        public void Display()
        {
            Console.WriteLine("Student Name: " + Name);
        }
    }

    public class Encapsulation
    {
        public static void Run()
        {
            Console.WriteLine("=== Encapsulation ===");

            Student student = new Student();
            student.Name = "Ali";
            student.Display();
        }
    }
}
