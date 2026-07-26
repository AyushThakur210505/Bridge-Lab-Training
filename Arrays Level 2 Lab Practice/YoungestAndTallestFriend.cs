using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Level_2_Lab_Practice
{
    internal class YoungestAndTallestFriend
    {
        public static void display()
        {
            string[] name = { "Amar", "Akbar", "Anthony" };
            int[] age = new int[3];
            double[] height = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nEnter Details of " + name[i]);

                Console.Write("Enter Age : ");
                age[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter Height : ");
                height[i] = double.Parse(Console.ReadLine());

                if (age[i] <= 0 || height[i] <= 0)
                {
                    Console.WriteLine("Invalid Input");
                    i--;
                }
            }

            int youngest = 0;
            int tallest = 0;

            for (int i = 1; i < 3; i++)
            {
                if (age[i] < age[youngest])
                {
                    youngest = i;
                }

                if (height[i] > height[tallest])
                {
                    tallest = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Youngest Friend : " + name[youngest]);
            Console.WriteLine("Age : " + age[youngest]);

            Console.WriteLine();

            Console.WriteLine("Tallest Friend : " + name[tallest]);
            Console.WriteLine("Height : " + height[tallest]);
        }
    }
}