using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class WindChillCalculator
    {
        public static void display()
        {
            Console.Write("Enter Temperature (°F) : ");
            double temperature = double.Parse(Console.ReadLine());

            Console.Write("Enter Wind Speed (mph) : ");
            double windSpeed = double.Parse(Console.ReadLine());

            double result = checker(temperature, windSpeed);

            Console.WriteLine("Wind Chill Temperature : " + result.ToString("F2"));
        }

        public static double checker(double temperature, double windSpeed)
        {
            double windChill = 35.74 +(0.6215 * temperature) +((0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16));

            return windChill;
        }
    }
}
