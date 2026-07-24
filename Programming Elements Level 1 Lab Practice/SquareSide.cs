using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class SquareSide
    {
        public static void display()
        {
            Console.Write("Enter Perimeter of Square: ");
            double perimeter = double.Parse(Console.ReadLine());

            double side = perimeter / 4;

            Console.WriteLine("The length of the side is " + side +
                              " whose perimeter is " + perimeter);
        }
    }
}
