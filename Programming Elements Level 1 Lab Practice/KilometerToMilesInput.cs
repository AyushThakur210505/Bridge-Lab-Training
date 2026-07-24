using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class KilometerToMilesInput
    {
        public static void display()
        {
            Console.Write("Enter distance in kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());

            double miles = kilometers / 1.6;

            Console.WriteLine("The total miles is " + miles.ToString("F2") +" mile for the given " + kilometers + " km");
        }
    }
}
