using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class ToggleCase
    {
        public static void display()
        {
            Console.Write("Enter a String : ");
            string text = Console.ReadLine();

            string result = Toggle(text);

            Console.WriteLine("Toggled String : " + result);
        }

        public static string Toggle(string text)
        {
            char[] characters = text.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (char.IsUpper(characters[i]))
                {
                    characters[i] = char.ToLower(characters[i]);
                }
                else if (char.IsLower(characters[i]))
                {
                    characters[i] = char.ToUpper(characters[i]);
                }
            }

            return new string(characters);
        }
    }
}