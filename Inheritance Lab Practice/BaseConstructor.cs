using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Person
    {
        public Person(string name)
        {
            Console.WriteLine("Person Name: " + name);
        }
    }

    class Student : Person
    {
        public Student(string name) : base(name)
        {
            Console.WriteLine("Student constructor called.");
        }
    }

    public class BaseConstructor
    {
        public static void Run()
        {
            Console.WriteLine("=== Base Constructor ===");

            Student student = new Student("Ali");
        }
    }
}