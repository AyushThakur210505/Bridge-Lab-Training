using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class SpringSeasonChecker
    {
        public static void display()
        {
            Console.Write("Enter the Date : ");
            int date = int.Parse(Console.ReadLine());

            Console.Write("Enter the Month Number : ");
                int month = int.Parse(Console.ReadLine());

            if((month==3 && date>= 20) || (month == 4) || (month == 5) ||(month==6 && date <= 20))
            {
                Console.WriteLine("Its a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }
    }
}
