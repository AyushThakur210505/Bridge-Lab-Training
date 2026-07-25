using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_3_Lab_Practice
{
    internal class DayOfWeekCalculator
    {
        public static void display()
        {
            Console.Write("Enter month: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Enter day: ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Enter year: ");
            int y = int.Parse(Console.ReadLine());

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;

            Console.WriteLine("Day of Week: " + d0);

            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;

                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}