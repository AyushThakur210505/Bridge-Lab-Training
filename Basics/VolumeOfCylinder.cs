using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    internal class VolumeOfCylinder
    {
        public static void display()
        {
            Console.Write("Enter Radius: ");
            double radius = double.Parse(Console.ReadLine());

            Console.Write("Enter Height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = Math.PI * radius * radius * height;

            Console.WriteLine("Volume of Cylinder = " + volume.ToString("F2"));
        }
    }
}
