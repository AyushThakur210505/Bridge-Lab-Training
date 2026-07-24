using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class FeetToYardMile
    {
        public static void display()
        {
            Console.Write("Enter Distance in Feet: ");
            double feet = double.Parse(Console.ReadLine());

            double yards = feet / 3;
            double miles = yards / 1760;

            Console.WriteLine("Distance in Feet = " + feet);
            Console.WriteLine("Distance in Yards = " + yards.ToString("F2"));
            Console.WriteLine("Distance in Miles = " + miles.ToString("F4"));
        }
    }
}
