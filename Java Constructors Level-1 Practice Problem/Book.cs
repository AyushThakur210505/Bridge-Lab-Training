using System;
using System.Collections.Generic;
using System.Text;

namespace Java_Constructors_Level_1_Practice_Problem
{
    internal class Book
    {
        private string title;
        private string author;
        private double price;

        public Book()
        {
            this.title = "Unkown";
            this.author = "Unkown";
            this.price = 0.00;

        }

        public Book(string title,string author,double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book Title is : " + title);
            Console.WriteLine("Book author is : " + author);
            Console.WriteLine("Book price is : " + price);
            Console.WriteLine();
        }
    }
}
