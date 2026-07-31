using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Java_Constructors_Level_1_Practice_Problem
{
    internal class Circle
    {
        private double radius;

        public Circle() : this(7.7)
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public void display()
        {
            Console.WriteLine("The Radius of the Circle is : " + radius);
            Console.WriteLine("Area of The Circle is : " + area());
            Console.WriteLine();
        }

        double area()
        {
            return (Math.PI * radius * radius);
        }
    }
}
