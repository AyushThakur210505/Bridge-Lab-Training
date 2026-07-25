using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class RocketCountdownWhile
    {
        public static void display()
        {
            Console.Write("Enter the Countdown Number : ");
            int counter = int.Parse(Console.ReadLine());

            while(counter > 0)
            {
                Console.WriteLine($"{counter}");
                counter--;
            }
        }
    }
}
