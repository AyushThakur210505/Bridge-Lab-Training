using System;
using System.Collections.Generic;
using System.Text;


namespace Key_words_Level_1_Lab_Practice
{
    internal class BankAccount
    {
        public static string bankName = "State Bank of India";
        private static int totalAccounts = 0;

        public readonly int AccountNumber;
        public string AccountHolderName;

        public BankAccount(int AccountNumber, string AccountHolderName)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolderName = AccountHolderName;
            totalAccounts++;
        }

        public void Display()
        {
            Console.WriteLine("Bank Name : " + bankName);
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Account Holder : " + AccountHolderName);
        }

        public static void GetTotalAccounts()
        {
            Console.WriteLine("Total Accounts : " + totalAccounts);
        }

        public static void display()
        {
            BankAccount account = new BankAccount(1001, "Ayush");

            if (account is BankAccount)
            {
                account.Display();
            }

            GetTotalAccounts();
        }
    }
}
