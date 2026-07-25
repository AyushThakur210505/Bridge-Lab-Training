using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_2_Lab_Practice
{
    internal class YoungestAndTallestFriend
    {
        public static void display()
        {
            Console.Write("Enter Amar's age : ");
            int amarAge = int.Parse(Console.ReadLine());

            Console.Write("Enter Amar's height (in cm): ");
            double amarHeight = double.Parse(Console.ReadLine());

            Console.Write("Enter Akbar's age: ");
            int akbarAge = int.Parse(Console.ReadLine());

            Console.Write("Enter Akbar's height (in cm): ");
            double akbarHeight = double.Parse(Console.ReadLine());

            Console.Write("Enter Anthony's age: ");
            int anthonyAge = int.Parse(Console.ReadLine());

            Console.Write("Enter Anthony's height (in cm): ");
            double anthonyHeight = double.Parse(Console.ReadLine());

            if (amarAge < akbarAge && amarAge < anthonyAge)
            {
                Console.WriteLine("\nYoungest Friend : Amar");
            }
            else if (akbarAge < amarAge && akbarAge < anthonyAge)
            {
                Console.WriteLine("\nYoungest Friend : Akbar");
            }
            else if (anthonyAge < amarAge && anthonyAge < akbarAge)
            {
                Console.WriteLine("\nYoungest Friend : Anthony");
            }
            else
            {
                Console.WriteLine("\nTwo or more friends have the same youngest age.");
            }

            if (amarHeight > akbarHeight && amarHeight > anthonyHeight)
            {
                Console.WriteLine("Tallest Friend: Amar");
            }
            else if (akbarHeight > amarHeight && akbarHeight > anthonyHeight)
            {
                Console.WriteLine("Tallest Friend: Akbar");
            }
            else if (anthonyHeight > amarHeight && anthonyHeight > akbarHeight)
            {
                Console.WriteLine("Tallest Friend: Anthony");
            }
            else
            {
                Console.WriteLine("Two or more friends have the same tallest height.");
            }
        }
    }
}