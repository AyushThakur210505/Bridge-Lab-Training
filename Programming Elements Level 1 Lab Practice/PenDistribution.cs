using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class PenDistribution
    {
        public static void display()
        {
            int totalPens = 14;
            int students = 3;

            int pensPerStudent = totalPens / students;
            int remainingPens = totalPens % students;

            Console.WriteLine("The Pen Per Student is " + pensPerStudent +" and the remaining pen not distributed is " + remainingPens);
        }
    }
}
