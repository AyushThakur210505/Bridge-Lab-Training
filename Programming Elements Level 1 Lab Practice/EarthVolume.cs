using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class EarthVolume
    {
        public static void display()
        {
            double radiusKm = 6378;

            double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

            double radiusMiles = radiusKm / 1.6;
            double volumeMiles = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);

            Console.WriteLine("The volume of Earth in cubic kilometers is " + volumeKm.ToString("F2"));
            Console.WriteLine("The volume of Earth in cubic miles is " + volumeMiles.ToString("F2"));
        }
    }
}
