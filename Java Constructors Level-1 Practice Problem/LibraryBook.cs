using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Java_Constructors_Level_1_Practice_Problem
{
    internal class LibraryBook
    {
        private string title;
        private string author;
        private double price;
        private bool availability = true;

        public LibraryBook()
        {

        }

        public LibraryBook(string title , string author,double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void display()
        {
            BorrowBook();
        }

        void BorrowBook()
        {
            if (availability)
            {
                Console.WriteLine($" U can borrow : {title} By { author}, Price : {price}");
                availability = false;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($" U can't borrow : {title} By {author}, Price : {price}");
                Console.WriteLine();
            }
        }
    }
}
