using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers_Practice_Problem
{
    internal class Book
    {
        public string ISBN;
        protected string title;
        private string author;

        public void SetDetails(string isbn, string bookTitle, string bookAuthor)
        {
            ISBN = isbn;
            title = bookTitle;
            author = bookAuthor;
        }

        public void SetAuthor(string bookAuthor)
        {
            author = bookAuthor;
        }

        public string GetAuthor()
        {
            return author;
        }
    }

    internal class EBook : Book
    {
        public void Display()
        {
            Console.WriteLine("ISBN : " + ISBN);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + GetAuthor());
        }
    }
}
