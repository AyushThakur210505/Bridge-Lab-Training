using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Built_In_Function_Practice_Problem
{
    internal class TimeZones
    {
        public static void display()
        {
            DateTimeOffset currentTime = DateTimeOffset.UtcNow;

            ShowTime("GMT", currentTime);

            TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            ShowTime("IST", TimeZoneInfo.ConvertTime(currentTime, ist));

            try
            {
                TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
                ShowTime("PST", TimeZoneInfo.ConvertTime(currentTime, pst));
            }
            catch
            {
                Console.WriteLine("Pacific Standard Time zone is not available on this system.");
            }
        }

        public static void ShowTime(string zoneName, DateTimeOffset time)
        {
            Console.WriteLine(zoneName + " : " + time);
        }
    }
}
