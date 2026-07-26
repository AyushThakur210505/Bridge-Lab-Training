using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Level_2_Lab_Practice
{
    internal class StudentGradeCalculator
    {
        public static void display()
        {
            Console.Write("Enter Number of Students : ");
            int n = int.Parse(Console.ReadLine());

            double[] physics = new double[n];
            double[] chemistry = new double[n];
            double[] maths = new double[n];
            double[] percentage = new double[n];
            string[] grade = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nStudent " + (i + 1));

                Console.Write("Physics : ");
                physics[i] = double.Parse(Console.ReadLine());

                Console.Write("Chemistry : ");
                chemistry[i] = double.Parse(Console.ReadLine());

                Console.Write("Maths : ");
                maths[i] = double.Parse(Console.ReadLine());

                if (physics[i] < 0 || chemistry[i] < 0 || maths[i] < 0)
                {
                    Console.WriteLine("Invalid Marks");
                    i--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3;

                if (percentage[i] >= 90)
                {
                    grade[i] = "A+";
                }
                else if (percentage[i] >= 80)
                {
                    grade[i] = "A";
                }
                else if (percentage[i] >= 70)
                {
                    grade[i] = "B";
                }
                else if (percentage[i] >= 60)
                {
                    grade[i] = "C";
                }
                else if (percentage[i] >= 50)
                {
                    grade[i] = "D";
                }
                else
                {
                    grade[i] = "F";
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(physics[i] + "\t" +chemistry[i] + "\t" +maths[i] + "\t" +percentage[i].ToString("F2") + "\t" +grade[i]);
            }
        }
    }
}