using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class UniversityFeeDiscount
    {
        public static void display()
        {
            double fee = 125000;
            double discountPercent = 10;

            double discount = (fee * discountPercent) / 100;
            double finalFee = fee - discount;

            Console.WriteLine("The discount amount is INR " + discount);
            Console.WriteLine("The final discounted fee is INR " + finalFee);
        }
    }
}
