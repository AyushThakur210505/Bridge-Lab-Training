using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class RocketCountdownFor
    {
        public static void display()
        {
            Console.Write("Enter a Number for CountDown : ");
            int counter = int.Parse(Console.ReadLine());

            for(int i = counter; i > 0; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
