using System;
using System.Collections.Generic;
using System.Text;

namespace Key_words_Level_1_Lab_Practice
{
    internal class Student
    {
        public static string UniversityName = "Chitkara University";
        private static int totalStudents = 0;

        public readonly int RollNumber;
        public string Name;
        public string Grade;

        public Student(int RollNumber, string Name, string Grade)
        {
            this.RollNumber = RollNumber;
            this.Name = Name;
            this.Grade = Grade;
            totalStudents++;
        }

        public void Display()
        {
            Console.WriteLine("University : " + UniversityName);
            Console.WriteLine("Roll Number : " + RollNumber);
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Grade : " + Grade);
        }

        public void UpdateGrade(string grade)
        {
            Grade = grade;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students : " + totalStudents);
        }

        public static void display()
        {
            Student student = new Student(101, "Ayush", "A");

            if (student is Student)
            {
                student.Display();

                student.UpdateGrade("A+");

                Console.WriteLine("\nAfter Grade Update");
                student.Display();
            }

            DisplayTotalStudents();
        }
    }
}
