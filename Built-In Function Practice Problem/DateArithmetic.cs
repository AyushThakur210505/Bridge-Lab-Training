using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Built_In_Function_Practice_Problem
{
    internal class DateArithmetic
    {
        public static void display()
        {
            DateTime date = GetDate();

            DateTime result = CalculateDate(date);

            Console.WriteLine("Final Date : " + result.ToString("dd/MM/yyyy"));
        }

        public static DateTime GetDate()
        {
            Console.Write("Enter Date (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            return DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public static DateTime CalculateDate(DateTime date)
        {
            date = date.AddDays(7);
            date = date.AddMonths(1);
            date = date.AddYears(2);
            date = date.AddDays(-21);

            return date;
        }
    }
}
