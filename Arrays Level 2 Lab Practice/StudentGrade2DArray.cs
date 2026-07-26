using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Level_2_Lab_Practice
{
    internal class StudentGrade2DArray
    {
        public static void display()
        {
            Console.Write("Enter Number of Students : ");
            int n = int.Parse(Console.ReadLine());

            double[,] marks = new double[n, 3];
            double[] percentage = new double[n];
            string[] grade = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nStudent " + (i + 1));

                Console.Write("Physics : ");
                marks[i, 0] = double.Parse(Console.ReadLine());

                Console.Write("Chemistry : ");
                marks[i, 1] = double.Parse(Console.ReadLine());

                Console.Write("Maths : ");
                marks[i, 2] = double.Parse(Console.ReadLine());

                if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
                {
                    Console.WriteLine("Invalid Marks");
                    i--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

                if (percentage[i] >= 90)
                    grade[i] = "A+";
                else if (percentage[i] >= 80)
                    grade[i] = "A";
                else if (percentage[i] >= 70)
                    grade[i] = "B";
                else if (percentage[i] >= 60)
                    grade[i] = "C";
                else if (percentage[i] >= 50)
                    grade[i] = "D";
                else
                    grade[i] = "F";
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(marks[i, 0] + "\t" +marks[i, 1] + "\t" +marks[i, 2] + "\t" +percentage[i].ToString("F2") + "\t" +grade[i]);
            }
        }
    }
}