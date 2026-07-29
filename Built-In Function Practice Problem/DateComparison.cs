using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Built_In_Function_Practice_Problem
{
    internal class DateComparison
    {
        public static void display()
        {
            DateTime date1 = GetDate("Enter First Date (dd/MM/yyyy): ");
            DateTime date2 = GetDate("Enter Second Date (dd/MM/yyyy): ");

            CompareDates(date1, date2);
        }

        public static DateTime GetDate(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            return DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public static void CompareDates(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                Console.WriteLine("First date is before the second date.");
            }
            else if (result > 0)
            {
                Console.WriteLine("First date is after the second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the same.");
            }
        }
    }
}