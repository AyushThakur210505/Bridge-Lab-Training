using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class SumUntilZero
    {
        public static void display()
        {
            double total = 0.0;

            while (true)
            {
                Console.Write("Enter the Number : ");
                double num = double.Parse(Console.ReadLine());
                if(num == 0)
                {
                    break;
                }
                else
                {
                    total += num;
                }
            }
            Console.WriteLine($"The Total Value : {total}");
        }
    }
}
