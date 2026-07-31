using System;

namespace Java_Constructors_Level_1_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book.cs
            //Book book = new Book();  // this is for default constructor
            //book.display();

            //Book book1 = new Book("Ayush Book Publication ", "Ayush Thakur", 15000);  // this is for parameterized constructor
            //book1.display();




            //Circle.cs
            //Circle circle = new Circle();  //Constructor chaining
            //circle.display();

            //Circle circle1 = new Circle(5);
            //circle1.display();




            //Person.cs
            //Person person = new Person("Ayush Thakur", "Cse", 1149); //Copy constructor
            //person.display();

            //Person person1 = new Person(person);
            //person1.display();




            //HotelBooking.cs
            //HotelBooking hotel = new HotelBooking("Ayush", "Single", 5);
            //hotel.display();

            //HotelBooking hotel1 = new HotelBooking(hotel);
            //hotel1.display();

            //HotelBooking hotel2 = new HotelBooking();
            //hotel2.display();




            //LibraryBook.cs
            //LibraryBook library = new LibraryBook("Ayush Book Publication ", "Ayush Thakur", 15000);
            //library.display();

            //library.display();




            //CarRental.cs
            CarRental car = new CarRental("Ayush", "Bmw", 10);
            car.display();
        }
    }
}
