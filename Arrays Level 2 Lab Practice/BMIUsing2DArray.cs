using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Level_2_Lab_Practice
{
    internal class BMIUsing2DArray
    {
        public static void display()
        {
            Console.Write("Enter Number of Persons : ");
            int n = int.Parse(Console.ReadLine());

            double[,] person = new double[n, 3];
            string[] status = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));

                Console.Write("Enter Weight (kg) : ");
                person[i, 0] = double.Parse(Console.ReadLine());

                Console.Write("Enter Height (m) : ");
                person[i, 1] = double.Parse(Console.ReadLine());

                if (person[i, 0] <= 0 || person[i, 1] <= 0)
                {
                    Console.WriteLine("Invalid Input");
                    i--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                person[i, 2] = person[i, 0] / (person[i, 1] * person[i, 1]);

                if (person[i, 2] < 18.5)
                {
                    status[i] = "Underweight";
                }
                else if (person[i, 2] < 25)
                {
                    status[i] = "Normal";
                }
                else if (person[i, 2] < 30)
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
                Console.WriteLine(person[i, 0] + "\t" +person[i, 1] + "\t" +person[i, 2].ToString("F2") + "\t" +status[i]);
            }
        }
    }
}
