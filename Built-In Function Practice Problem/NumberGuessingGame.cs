using System;
using System.Collections.Generic;
using System.Text;

namespace Built_In_Function_Practice_Problem
{
    internal class NumberGuessingGame
    {
        public static void display()
        {
            int low = 1;
            int high = 100;
            string feedback;

            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("The computer will guess your number.");
            Console.WriteLine("Enter:");
            Console.WriteLine("high    -> Guess is too high");
            Console.WriteLine("low     -> Guess is too low");
            Console.WriteLine("correct -> Guess is correct");

            do
            {
                int guess = GenerateGuess(low, high);

                Console.WriteLine("\nComputer Guess: " + guess);

                feedback = GetFeedback();

                if (feedback == "high")
                {
                    high = guess - 1;
                }
                else if (feedback == "low")
                {
                    low = guess + 1;
                }

            } while (feedback != "correct");

            Console.WriteLine("\nComputer guessed your number successfully!");
        }

        public static int GenerateGuess(int low, int high)
        {
            return (low + high) / 2;
        }

        public static string GetFeedback()
        {
            Console.Write("Enter feedback (high/low/correct): ");
            return Console.ReadLine().ToLower();
        }
    }
}
