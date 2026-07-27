using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_2_Practice_Programs
{
    internal class LeapYear
    {
        public static void display()
        {
            Console.Write("Enter Year : ");
            int year = int.Parse(Console.ReadLine());

            if (year < 1582)
            {
                Console.WriteLine("Leap year calculation is valid only for years >= 1582.");
                return;
            }

            bool result = IsLeapYear(year);

            if (result)
                Console.WriteLine(year + " is a Leap Year.");
            else
                Console.WriteLine(year + " is not a Leap Year.");
        }

        public static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                return true;

            return false;
        }
    }
}
