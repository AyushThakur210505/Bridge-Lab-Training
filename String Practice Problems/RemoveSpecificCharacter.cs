using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class RemoveSpecificCharacter
    {
        public static void display()
        {
            Console.Write("Enter a String : ");
            string text = Console.ReadLine();

            Console.Write("Enter Character to Remove : ");
            char ch = Convert.ToChar(Console.ReadLine());

            string result = RemoveCharacter(text, ch);

            Console.WriteLine("Updated String : " + result);
        }

        public static string RemoveCharacter(string text, char ch)
        {
            string result = "";

            foreach (char c in text)
            {
                if (char.ToLower(c) != char.ToLower(ch))
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
