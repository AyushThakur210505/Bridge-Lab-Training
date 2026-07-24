using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class FindHarryAge
    {
        public static void display()
        {
            int birthYear = 2000;
            int currentYear = 2024;

            int age = currentYear - birthYear;

            Console.WriteLine("Harry's age in 2024 is " + age);
        }
    }
}
