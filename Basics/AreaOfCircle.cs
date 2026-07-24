using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    internal class AreaOfCircle
    {
        public static void display()
        {
            Console.Write("Enter Radius: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("Area of Circle = " + area.ToString("F2"));
        }
    }
}
