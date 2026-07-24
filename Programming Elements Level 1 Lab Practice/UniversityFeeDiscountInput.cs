using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class UniversityFeeDiscountInput
    {
        public static void display()
        {
            Console.Write("Enter Course Fee: ");
            double fee = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Percentage: ");
            double discountPercent = double.Parse(Console.ReadLine());

            double discount = (fee * discountPercent) / 100;
            double finalFee = fee - discount;

            Console.WriteLine("The discount amount is INR " + discount);
            Console.WriteLine("The final discounted fee is INR " + finalFee);
        }
    }
}
