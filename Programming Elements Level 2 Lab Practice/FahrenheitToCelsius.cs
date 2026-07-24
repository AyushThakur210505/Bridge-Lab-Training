using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class FahrenheitToCelsius
    {
        public static void display()
        {
            Console.Write("Enter Temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("The " + fahrenheit +" Fahrenheit is " +celsius.ToString("F2") +" Celsius");
        }
    }
}
