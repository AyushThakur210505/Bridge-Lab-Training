using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class HeightConverter
    {
        public static void display()
        {
            Console.Write("Enter Height in Centimeters: ");
            double centimeters = double.Parse(Console.ReadLine());

            double totalInches = centimeters / 2.54;
            int feet = (int)(totalInches / 12);
            double inches = totalInches % 12;

            Console.WriteLine("Your Height in cm is " + centimeters +
                              " while in feet is " + feet +
                              " and inches is " + inches.ToString("F2"));
        }
    }
}
