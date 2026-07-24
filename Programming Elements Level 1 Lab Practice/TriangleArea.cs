using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class TriangleArea
    {
        public static void display()
        {
            Console.Write("Enter Base: ");
            double baseValue = double.Parse(Console.ReadLine());

            Console.Write("Enter Height: ");
            double height = double.Parse(Console.ReadLine());

            double area = 0.5 * baseValue * height;

            Console.WriteLine("Area of Triangle = " + area + " square units");
        }
    }
}
