using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation__Polymorphism__Interface_and_Abstract_Class_Practice_problem
{
    interface ILoanable
    {
        void ApplyForLoan();
        double CalculateLoanEligibility();
    }

    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string HolderName
        {
            get { return holderName; }
            set { holderName = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BankAccount(string number, string name, double balance)
        {
            AccountNumber = number;
            HolderName = name;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine("Insufficient Balance");
        }

        public abstract double CalculateInterest();

        public void DisplayDetails()
        {
            Console.WriteLine("Account No : " + AccountNumber);
            Console.WriteLine("Holder     : " + HolderName);
            Console.WriteLine("Balance    : " + Balance);
        }
    }

    class SavingsAccount : BankAccount, ILoanable
    {
        public SavingsAccount(string number, string name, double balance)
            : base(number, name, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.05;
        }

        public void ApplyForLoan()
        {
            Console.WriteLine("Loan Applied Successfully");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 5;
        }
    }

    class CurrentAccount : BankAccount, ILoanable
    {
        public CurrentAccount(string number, string name, double balance)
            : base(number, name, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.02;
        }

        public void ApplyForLoan()
        {
            Console.WriteLine("Loan Applied Successfully");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 3;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            accounts.Add(new SavingsAccount("SB101", "Ali", 50000));
            accounts.Add(new CurrentAccount("CA201", "Sara", 70000));

            foreach (BankAccount account in accounts)
            {
                account.DisplayDetails();

                Console.WriteLine("Interest : " + account.CalculateInterest());

                if (account is ILoanable loan)
                {
                    loan.ApplyForLoan();
                    Console.WriteLine("Loan Eligibility : " + loan.CalculateLoanEligibility());
                }

                Console.WriteLine("----------------------------");
            }

            Console.ReadKey();
        }
    }
}
