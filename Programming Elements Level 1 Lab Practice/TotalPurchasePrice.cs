using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class TotalPurchasePrice
    {
        public static void display()
        {
            Console.Write("Enter Unit Price: ");
            double unitPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            double totalPrice = unitPrice * quantity;

            Console.WriteLine("The total purchase price is INR " +
                              totalPrice + " if the quantity " +
                              quantity + " and unit price is INR " +
                              unitPrice);
        }
    }
}