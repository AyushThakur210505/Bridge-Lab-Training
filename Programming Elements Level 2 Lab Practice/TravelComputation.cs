using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class TravelComputation
    {
        public static void display()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter From City: ");
            string fromCity = Console.ReadLine();

            Console.Write("Enter Via City: ");
            string viaCity = Console.ReadLine();

            Console.Write("Enter Destination City: ");
            string toCity = Console.ReadLine();

            Console.Write("Enter Distance from First City to Via City (km): ");
            double distanceOne = double.Parse(Console.ReadLine());

            Console.Write("Enter Distance from Via City to Destination (km): ");
            double distanceTwo = double.Parse(Console.ReadLine());

            Console.Write("Enter Time for First Journey (minutes): ");
            int timeOne = int.Parse(Console.ReadLine());

            Console.Write("Enter Time for Second Journey (minutes): ");
            int timeTwo = int.Parse(Console.ReadLine());

            double totalDistance = distanceOne + distanceTwo;
            int totalTime = timeOne + timeTwo;

            Console.WriteLine("The Total Distance travelled by " + name +
                              " from " + fromCity + " to " + toCity +
                              " via " + viaCity + " is " + totalDistance +
                              " km and the Total Time taken is " +
                              totalTime + " minutes");
        }
    }
}
