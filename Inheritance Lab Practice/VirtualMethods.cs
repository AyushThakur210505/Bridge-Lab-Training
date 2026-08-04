using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Payment
    {
        public virtual void Process()
        {
            Console.WriteLine("Processing payment.");
        }

        public void GenerateReceipt()
        {
            Console.WriteLine("Receipt generated.");
        }
    }

    class CreditCardPayment : Payment
    {
        public override void Process()
        {
            Console.WriteLine("Processing credit card payment.");
        }
    }

    public class VirtualMethods
    {
        public static void Run()
        {
            Console.WriteLine("=== Virtual Methods ===");

            Payment payment = new CreditCardPayment();
            payment.Process();
            payment.GenerateReceipt();
        }
    }
}