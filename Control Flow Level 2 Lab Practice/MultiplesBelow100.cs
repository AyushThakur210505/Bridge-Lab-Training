using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_2_Lab_Practice
{
    internal class MultiplesBelow100
    {
        public static void display()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiples below 100:");

            for (int i = number; i < 100; i += number)
            {
                Console.Write(i + " ");
            }
        }
    }
}
