using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_2_Lab_Practice
{
    internal class BMICalculator
    {
        public static void display()
        {
            Console.Write("Enter Weight in Kg : ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter height in cm : ");
            double height = double.Parse(Console.ReadLine());

            height /= 100; // to convert it in cm to m

            double Bmi = weight / (height * height);
            if (Bmi <= 18.4)
            {
                Console.WriteLine("Underweight");
            }
            if (Bmi >= 18.5 && Bmi <=24.9)
            {
                Console.WriteLine("Normal");
            }
            if (Bmi >= 25.0 && Bmi <=39.9)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
        }
    }
}
