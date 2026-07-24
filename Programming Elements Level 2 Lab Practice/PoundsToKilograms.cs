using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class PoundsToKilograms
    {
        public static void display()
        {
            Console.Write("Enter Weight in Pounds: ");
            double pounds = double.Parse(Console.ReadLine());

            double kilograms = pounds / 2.2;

            Console.WriteLine("The weight of the person in pounds is " +
                              pounds +
                              " and in kg is " +
                              kilograms.ToString("F2"));
        }
    }
}