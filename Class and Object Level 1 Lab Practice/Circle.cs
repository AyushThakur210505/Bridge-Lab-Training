using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Class_and_Object_Level_1_Lab_Practice
{
    internal class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public void display()
        {
            Console.WriteLine("Area of the circle is : " + area());
            Console.WriteLine("Perimeter of the circle is : " + perimeter());
        }
        double area()
        {
            return (Math.PI*radius*radius);
        }
        double perimeter()
        {
            return (2 * Math.PI * radius);
        }
    }
}
