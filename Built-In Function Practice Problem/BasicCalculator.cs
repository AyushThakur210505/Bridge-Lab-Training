using System;
using System.Collections.Generic;
using System.Text;

namespace Built_In_Function_Practice_Problem
{
    internal class BasicCalculator
    {
        public static void display()
        {
            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose an Operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + Add(num1, num2));
                    break;

                case 2:
                    Console.WriteLine("Result = " + Subtract(num1, num2));
                    break;

                case 3:
                    Console.WriteLine("Result = " + Multiply(num1, num2));
                    break;

                case 4:
                    if (num2 == 0)
                        Console.WriteLine("Division by zero is not possible.");
                    else
                        Console.WriteLine("Result = " + Divide(num1, num2));
                    break;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}