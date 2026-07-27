using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_2_Practice_Programs
{
    internal class BMICalculator
    {
        public static void display()
        {
            double[,] persons = new double[10, 3];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter Weight (kg) of Person {i + 1}: ");
                persons[i, 0] = double.Parse(Console.ReadLine());

                Console.Write($"Enter Height (cm) of Person {i + 1}: ");
                persons[i, 1] = double.Parse(Console.ReadLine());
            }

            CalculateBMI(persons);
            string[] status = GetBMIStatus(persons);

            Console.WriteLine("\nWeight\tHeight\tBMI\tStatus");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{persons[i, 0]}\t{persons[i, 1]}\t{persons[i, 2]:F2}\t{status[i]}");
            }
        }

        public static void CalculateBMI(double[,] persons)
        {
            for (int i = 0; i < 10; i++)
            {
                double heightInMeter = persons[i, 1] / 100;
                persons[i, 2] = persons[i, 0] / (heightInMeter * heightInMeter);
            }
        }

        public static string[] GetBMIStatus(double[,] persons)
        {
            string[] status = new string[10];

            for (int i = 0; i < 10; i++)
            {
                double bmi = persons[i, 2];

                if (bmi < 18.5)
                    status[i] = "Underweight";
                else if (bmi < 25)
                    status[i] = "Normal";
                else if (bmi < 30)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            return status;
        }
    }
}
