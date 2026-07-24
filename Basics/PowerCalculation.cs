using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    internal class PowerCalculation
    {
        public static void display()
        {
            Console.Write("Enter Base: ");
            double baseNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter Exponent: ");
            double exponent = double.Parse(Console.ReadLine());

            double result = Math.Pow(baseNumber, exponent);

            Console.WriteLine("Result = " + result);
        }
    }
}