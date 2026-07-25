using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class OddEvenPrinter
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"The Number {i} is Even");
                }
                else
                {
                    Console.WriteLine($"The Number {i} is Odd");
                }
            }
        }
    }
}
