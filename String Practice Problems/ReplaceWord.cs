using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class ReplaceWord
    {
        public static void display()
        {
            Console.Write("Enter a Sentence : ");
            string sentence = Console.ReadLine();

            Console.Write("Enter Word to Replace : ");
            string oldWord = Console.ReadLine();

            Console.Write("Enter New Word : ");
            string newWord = Console.ReadLine();

            string result = Replace(sentence, oldWord, newWord);

            Console.WriteLine("Updated Sentence : ");
            Console.WriteLine(result);
        }

        public static string Replace(string sentence, string oldWord, string newWord)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(oldWord, StringComparison.OrdinalIgnoreCase))
                {
                    words[i] = newWord;
                }
            }

            return string.Join(" ", words);
        }
    }
}
