using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class CountVowelsAndConsonants
    {
        public static void display()
        {
            Console.Write("Enter a String : ");
            string text = Console.ReadLine();

            int[] result = Count(text);

            Console.WriteLine("Vowels : " + result[0]);
            Console.WriteLine("Consonants : " + result[1]);
        }

        public static int[] Count(string text)
        {
            int vowels = 0;
            int consonants = 0;

            text = text.ToLower();

            foreach (char ch in text)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }

            return new int[] { vowels, consonants };
        }
    }
}
