using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class SpringSeason
    {
        public static void display()
        {
            Console.Write("Enter the Date : ");
            int date = int.Parse(Console.ReadLine());

            Console.Write("Enter the Month Number : ");
            int month = int.Parse(Console.ReadLine());

            bool result = season(date, month);
            if (result)
            {
                Console.WriteLine("Its a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }
        public static bool season(int date,int month)
        {
            if((date>=20 && month==3)||(month == 4)||(month==5)||(month==6 && date <= 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
