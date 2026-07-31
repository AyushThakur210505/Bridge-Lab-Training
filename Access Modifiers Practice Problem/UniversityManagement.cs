using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers_Practice_Problem
{
    internal class Student
    {
        public int rollNumber;
        protected string name;
        private double cgpa;

        public void SetDetails(int roll, string studentName, double studentCgpa)
        {
            rollNumber = roll;
            name = studentName;
            cgpa = studentCgpa;
        }

        public void SetCGPA(double studentCgpa)
        {
            cgpa = studentCgpa;
        }

        public double GetCGPA()
        {
            return cgpa;
        }
    }

    internal class PostgraduateStudent : Student
    {
        public void Display()
        {
            Console.WriteLine("Roll Number : " + rollNumber);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("CGPA : " + GetCGPA());
        }
    }
}
