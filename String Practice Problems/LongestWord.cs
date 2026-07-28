using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class LongestWord
    {
        public static void display()
        {
            Console.Write("Enter a Sentence : ");
            string sentence = Console.ReadLine();

            string longest = FindLongestWord(sentence);

            Console.WriteLine("Longest Word : " + longest);
        }

        public static string FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');

            string longest = "";

            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }

            return longest;
        }
    }
}
