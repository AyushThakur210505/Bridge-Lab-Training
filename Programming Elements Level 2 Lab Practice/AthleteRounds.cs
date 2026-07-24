using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class AthleteRounds
    {
        public static void display()
        {
            Console.Write("Enter Side 1 (meters): ");
            double sideOne = double.Parse(Console.ReadLine());

            Console.Write("Enter Side 2 (meters): ");
            double sideTwo = double.Parse(Console.ReadLine());

            Console.Write("Enter Side 3 (meters): ");
            double sideThree = double.Parse(Console.ReadLine());

            double perimeter = sideOne + sideTwo + sideThree;
            double rounds = 5000 / perimeter;

            Console.WriteLine("The total number of rounds the athlete will run is " +rounds.ToString("F2") +" to complete 5 km");
        }
    }
}
