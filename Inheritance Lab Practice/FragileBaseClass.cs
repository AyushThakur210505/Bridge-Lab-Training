using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Account
    {
        protected decimal Balance;

        public Account(decimal balance)
        {
            Balance = balance;
        }

        public virtual void DisplayBalance()
        {
            Console.WriteLine("Balance: $" + Balance);
        }
    }

    class SavingsAccount : Account
    {
        public SavingsAccount(decimal balance) : base(balance)
        {
        }

        public override void DisplayBalance()
        {
            Console.WriteLine("Savings Balance: $" + Balance);
        }
    }

    public class FragileBaseClass
    {
        public static void Run()
        {
            Console.WriteLine("=== Fragile Base Class ===");

            SavingsAccount account = new SavingsAccount(5000);
            account.DisplayBalance();
        }
    }
}
