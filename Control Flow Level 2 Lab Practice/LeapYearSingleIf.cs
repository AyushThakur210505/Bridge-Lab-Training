using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_2_Lab_Practice
{
    internal class LeapYearSingleIf
    {
        public static void display()
        {
            Console.Write("Enter a year : ");
            int year = int.Parse(Console.ReadLine());

            if (year <= 1582)
            {
                Console.WriteLine("The LeapYear program only works for year >= 1582, corresponding to a year in the Gregorian calendar");
            }
            else if ((year%4 == 0 && year%100 !=0) || (year%400==0))
            {
                Console.WriteLine("Its a Leap Year");
            }
            else
            {
                Console.WriteLine("Its not a Leap Year");
            }
        }
    }
}
