using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_2_Practice_Programs
{
    internal class UnitConverter1
    {
        public static void display()
        {
            Console.Write("Enter Distance in Kilometers : ");
            double km = double.Parse(Console.ReadLine());

            Console.Write("Enter Distance in Miles : ");
            double miles = double.Parse(Console.ReadLine());

            Console.Write("Enter Length in Meters : ");
            double meters = double.Parse(Console.ReadLine());

            Console.Write("Enter Length in Feet : ");
            double feet = double.Parse(Console.ReadLine());

            Console.WriteLine("\nConversions:");
            Console.WriteLine("Kilometers to Miles : " + ConvertKmToMiles(km).ToString("F2"));
            Console.WriteLine("Miles to Kilometers : " + ConvertMilesToKm(miles).ToString("F2"));
            Console.WriteLine("Meters to Feet : " + ConvertMetersToFeet(meters).ToString("F2"));
            Console.WriteLine("Feet to Meters : " + ConvertFeetToMeters(feet).ToString("F2"));
        }

        public static double ConvertKmToMiles(double km)
        {
            return km * 0.621371;
        }

        public static double ConvertMilesToKm(double miles)
        {
            return miles * 1.60934;
        }

        public static double ConvertMetersToFeet(double meters)
        {
            return meters * 3.28084;
        }

        public static double ConvertFeetToMeters(double feet)
        {
            return feet * 0.3048;
        }
    }
}
