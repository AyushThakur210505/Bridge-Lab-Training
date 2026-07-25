using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class MultiplicationTableSixToNine
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{num} * {i} : {num * i}");
            }
        }
    }
}
