using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class CalendarDisplay
    {
        public static void display()
        {
            Console.Write("Enter Month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            DisplayCalendar(month, year);
        }

        public static void DisplayCalendar(int month, int year)
        {
            string[] months =
            {
                "January","February","March","April","May","June","July","August","September","October","November","December"
            };

            int days = DateTime.DaysInMonth(year, month);

            DateTime firstDay = new DateTime(year, month, 1);
            int startDay = (int)firstDay.DayOfWeek;

            Console.WriteLine("\n\t" + months[month - 1] + " " + year);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            for (int i = 0; i < startDay; i++)
            {
                Console.Write("    ");
            }

            for (int day = 1; day <= days; day++)
            {
                Console.Write($"{day,3} ");

                if ((day + startDay) % 7 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
