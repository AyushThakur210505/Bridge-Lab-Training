using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    internal class KilometersToMiles
    {
        public static void display()
        {
            Console.Write("Enter Distance in Kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());

            double miles = kilometers * 0.621371;

            Console.WriteLine("Distance in Miles = " + miles.ToString("F2"));
        }
    }
}
