using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_2_Practice_Programs
{
    internal class UnitConverter3
    {
        public static void display()
        {
            Console.Write("Enter Temperature in Fahrenheit : ");
            double fahrenheit = double.Parse(Console.ReadLine());

            Console.Write("Enter Temperature in Celsius : ");
            double celsius = double.Parse(Console.ReadLine());

            Console.Write("Enter Weight in Pounds : ");
            double pounds = double.Parse(Console.ReadLine());

            Console.Write("Enter Weight in Kilograms : ");
            double kilograms = double.Parse(Console.ReadLine());

            Console.Write("Enter Volume in Gallons : ");
            double gallons = double.Parse(Console.ReadLine());

            Console.Write("Enter Volume in Liters : ");
            double liters = double.Parse(Console.ReadLine());

            Console.WriteLine("\nConversions:");
            Console.WriteLine("Fahrenheit to Celsius : " + ConvertFahrenheitToCelsius(fahrenheit).ToString("F2"));
            Console.WriteLine("Celsius to Fahrenheit : " + ConvertCelsiusToFahrenheit(celsius).ToString("F2"));
            Console.WriteLine("Pounds to Kilograms : " + ConvertPoundsToKilograms(pounds).ToString("F2"));
            Console.WriteLine("Kilograms to Pounds : " + ConvertKilogramsToPounds(kilograms).ToString("F2"));
            Console.WriteLine("Gallons to Liters : " + ConvertGallonsToLiters(gallons).ToString("F2"));
            Console.WriteLine("Liters to Gallons : " + ConvertLitersToGallons(liters).ToString("F2"));
        }

        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double ConvertPoundsToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }

        public static double ConvertKilogramsToPounds(double kilograms)
        {
            return kilograms * 2.20462;
        }

        public static double ConvertGallonsToLiters(double gallons)
        {
            return gallons * 3.78541;
        }

        public static double ConvertLitersToGallons(double liters)
        {
            return liters * 0.264172;
        }
    }
}
