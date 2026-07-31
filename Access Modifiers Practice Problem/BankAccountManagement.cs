using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers_Practice_Problem
{
    internal class BankAccount
    {
        public string accountNumber;
        protected string accountHolder;
        private double balance;

        public void SetDetails(string number, string holder, double amount)
        {
            accountNumber = number;
            accountHolder = holder;
            balance = amount;
        }

        public void SetBalance(double amount)
        {
            balance = amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    internal class SavingsAccount : BankAccount
    {
        public void Display()
        {
            Console.WriteLine("Account Number : " + accountNumber);
            Console.WriteLine("Account Holder : " + accountHolder);
            Console.WriteLine("Balance : " + GetBalance());
        }
    }
}
