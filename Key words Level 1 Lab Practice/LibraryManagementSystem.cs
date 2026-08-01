using System;
using System.Collections.Generic;
using System.Text;

namespace Key_words_Level_1_Lab_Practice
{
    internal class Book
    {
        public static string LibraryName = "Central Library";

        public readonly string ISBN;

        public string Title;
        public string Author;

        public Book(string ISBN, string Title, string Author)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
        }

        public void Display()
        {
            Console.WriteLine("Library Name : " + LibraryName);
            Console.WriteLine("ISBN : " + ISBN);
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Author : " + Author);
        }

        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name : " + LibraryName);
        }

        public static void display()
        {
            Book book = new Book("978-123456789", "C# Programming", "John Smith");

            if (book is Book)
            {
                book.Display();
            }

            DisplayLibraryName();
        }
    }
}
