using System;
using System.Collections.Generic;
using System.Text;

namespace Java_Constructors_Level_1_Practice_Problem
{
    internal class Person
    {
        private string name;
        private string branch;
        private int rollno;

        public Person(string name,string branch,int rollno)
        {
            this.name = name;
            this.branch = branch;
            this.rollno = rollno;
        }

        public Person(Person other)
        {
            this.name = other.name;
            this.branch = other.branch;
            this.rollno = other.rollno;
        }

        public void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Branch : " + branch);
            Console.WriteLine("RollNo : " + rollno);
            Console.WriteLine();

        }


    }
}
