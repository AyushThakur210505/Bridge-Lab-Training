using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Level_2_Lab_Practice
{
    internal class BMICalculator
    {
        public static void display()
        {
            Console.Write("Enter Number of Persons : ");
            int n = int.Parse(Console.ReadLine());

            double[] weight = new double[n];
            double[] height = new double[n];
            double[] bmi = new double[n];
            string[] status = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));

                Console.Write("Enter Weight (kg) : ");
                weight[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter Height (m) : ");
                height[i] = double.Parse(Console.ReadLine());

                if (weight[i] <= 0 || height[i] <= 0)
                {
                    Console.WriteLine("Invalid Input");
                    i--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                bmi[i] = weight[i] / (height[i] * height[i]);

                if (bmi[i] < 18.5)
                {
                    status[i] = "Underweight";
                }
                else if (bmi[i] < 25)
                {
                    status[i] = "Normal";
                }
                else if (bmi[i] < 30)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + "\t" + height[i] + "\t" + weight[i] + "\t" + bmi[i].ToString("F2") + "\t" + status[i]);
            }
        }
    }
}