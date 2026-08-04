using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    abstract class Shape
    {
        public abstract double Area();

        public void Display()
        {
            Console.WriteLine("Calculating area...");
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
    }

    public class AbstractClass
    {
        public static void Run()
        {
            Console.WriteLine("=== Abstract Class ===");

            Circle circle = new Circle(5);

            circle.Display();
            Console.WriteLine("Area: " + circle.Area());
        }
    }
}
