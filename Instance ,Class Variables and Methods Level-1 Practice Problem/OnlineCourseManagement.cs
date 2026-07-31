using System;
using System.Collections.Generic;
using System.Text;

namespace Java_Instance__Class_Variables_and_Methods_Level_1_Practice_Problem
{
    internal class OnlineCourseManagement
    {
        private string courseName;
        private double durations;
        private double fees;

        private static string instituteName = "Chitkara University";


        public OnlineCourseManagement(string courseName,double durations,double fees)
        {
            this.courseName = courseName;
            this.durations = durations;
            this.fees = fees;
        }
        public void DisplayCourseDetails()
        {
            Console.WriteLine("The Institution name is : " + instituteName);
            Console.WriteLine("The Course Name is : " + courseName);
            Console.WriteLine("The Course duration is : " + durations);
            Console.WriteLine("The Course fees is : " + fees);
        }
        public static void UpdateInstitutionName(string newInstituteName)
        {
            instituteName = newInstituteName;
        }
    }
}
