using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    internal class PerimeterOfRectangle
    {
        public static void display()
        {
            Console.Write("Enter Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            double width = double.Parse(Console.ReadLine());

            double perimeter = 2 * (length + width);

            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
