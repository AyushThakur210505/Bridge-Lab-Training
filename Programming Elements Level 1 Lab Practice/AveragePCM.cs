using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class AveragePCM
    {
        public static void display()
        {
            int maths = 94;
            int physics = 95;
            int chemistry = 96;

            double average = (maths + physics + chemistry) / 3.0;

            Console.WriteLine("Sam's average mark in PCM is " + average);
        }
    }
}
