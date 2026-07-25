using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_3_Lab_Practice
{
    internal class SwitchCalculator
    {
        public static void display()
        {
            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    {
                        Console.WriteLine("Result: " + (first + second));
                        break;
                    }

                case "-":
                    {
                        Console.WriteLine("Result: " + (first - second));
                        break;
                    }

                case "*":
                    {
                        Console.WriteLine("Result: " + (first * second));
                        break;
                    }

                case "/":
                    {
                        if (second != 0)
                        {
                            Console.WriteLine("Result: " + (first / second));
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid Operator.");
                        break;
                    }
            }
        }
    }
}