using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Class_and_Object_Level_1_Lab_Practice
{
    internal class BookDetails
    {
        private string title;
        private string author;
        private double price;
        
        public BookDetails(string title,string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book Title : " + title);
            Console.WriteLine("Book Author : " + author);
            Console.WriteLine("Book Price : " + price);
        }
    }
}
