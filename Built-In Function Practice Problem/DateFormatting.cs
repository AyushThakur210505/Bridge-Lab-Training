using System;
using System.Collections.Generic;
using System.Text;
namespace Built_In_Function_Practice_Problem
{
    internal class DateFormatting
    {
        public static void display()
        {
            DateTime currentDate = DateTime.Now;

            ShowFormats(currentDate);
        }

        public static void ShowFormats(DateTime date)
        {
            Console.WriteLine("Format 1 : " + date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Format 2 : " + date.ToString("yyyy-MM-dd"));
            Console.WriteLine("Format 3 : " + date.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
