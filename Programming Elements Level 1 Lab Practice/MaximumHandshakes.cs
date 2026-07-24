using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class MaximumHandshakes
    {
        public static void display()
        {
            Console.Write("Enter Number of Students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

            Console.WriteLine("The maximum number of possible handshakes is " + handshakes);
        }
    }
}
