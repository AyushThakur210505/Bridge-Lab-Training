using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class CelsiusToFahrenheit
    {
        public static void display()
        {
            Console.Write("Enter Temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("The " + celsius +
                              " Celsius is " +
                              fahrenheit.ToString("F2") +
                              " Fahrenheit");
        }
    }
}
