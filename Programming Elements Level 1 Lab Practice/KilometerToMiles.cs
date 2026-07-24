using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class KilometerToMiles
    {
        public static void display()
        {
            double kilometers = 10.8;
            double miles = kilometers / 1.6;

            Console.WriteLine("The distance " + kilometers + " km in miles is " + miles);
        }
    }
}
