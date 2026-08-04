using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Calculator
    {
        public virtual void Display()
        {
            Console.WriteLine("Display without parameters.");
        }

        public void Display(int number)
        {
            Console.WriteLine("Number: " + number);
        }
    }

    class AdvancedCalculator : Calculator
    {
        public override void Display()
        {
            Console.WriteLine("Overridden display method.");
        }
    }

    public class MethodOverloading
    {
        public static void Run()
        {
            Console.WriteLine("=== Method Overloading and Overriding ===");

            AdvancedCalculator calculator = new AdvancedCalculator();

            calculator.Display();
            calculator.Display(100);
        }
    }
}