using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation__Polymorphism__Interface_and_Abstract_Class_Practice_problem
{
    interface IReservable
    {
        void ReserveItem();
        void CheckAvailability();
    }

    abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;
        private string borrower;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Borrower
        {
            set { borrower = value; }
        }

        public LibraryItem(int id, string title, string author)
        {
            ItemId = id;
            Title = title;
            Author = author;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine("Item ID : " + ItemId);
            Console.WriteLine("Title   : " + Title);
            Console.WriteLine("Author  : " + Author);
        }
    }

    class Book : LibraryItem, IReservable
    {
        public Book(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 14;
        }

        public void ReserveItem()
        {
            Console.WriteLine("Book Reserved");
        }

        public void CheckAvailability()
        {
            Console.WriteLine("Book Available");
        }
    }

    class Magazine : LibraryItem, IReservable
    {
        public Magazine(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public void ReserveItem()
        {
            Console.WriteLine("Magazine Reserved");
        }

        public void CheckAvailability()
        {
            Console.WriteLine("Magazine Available");
        }
    }

    class DVD : LibraryItem, IReservable
    {
        public DVD(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem()
        {
            Console.WriteLine("DVD Reserved");
        }

        public void CheckAvailability()
        {
            Console.WriteLine("DVD Available");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<LibraryItem> items = new List<LibraryItem>();

            items.Add(new Book(1, "C# Programming", "John"));
            items.Add(new Magazine(2, "Tech Today", "Smith"));
            items.Add(new DVD(3, "Avengers", "Marvel"));

            foreach (LibraryItem item in items)
            {
                item.GetItemDetails();
                Console.WriteLine("Loan Duration : " + item.GetLoanDuration() + " Days");

                if (item is IReservable reserve)
                {
                    reserve.CheckAvailability();
                    reserve.ReserveItem();
                }

                Console.WriteLine("---------------------------");
            }

            Console.ReadKey();
        }
    }
}
