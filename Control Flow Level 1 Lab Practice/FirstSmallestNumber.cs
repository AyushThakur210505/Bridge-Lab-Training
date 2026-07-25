using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class FirstSmallestNumber
    {
        public static void display()
        {
            Console.Write("Enter the First Number : ");
            int first_num = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            int second_num = int.Parse(Console.ReadLine());

            Console.Write("Enter the Third Number : ");
            int third_num = int.Parse(Console.ReadLine());

            if (first_num < second_num && first_num < third_num)
            {
                Console.WriteLine($"The first Number {first_num} is smallest.");
            }
            else
            {
                Console.WriteLine($"The first Number {first_num} is not smallest.");
            }
        }
    }
}
