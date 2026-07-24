using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    internal class CelsiusToFahrenheit
    {
        public static void display()
        {
            Console.Write("Enter Temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);
        }
    }
}
