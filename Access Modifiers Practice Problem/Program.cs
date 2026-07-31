using System;

namespace Access_Modifiers_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student
            //PostgraduateStudent student = new PostgraduateStudent();
            //student.SetDetails(101, "Ayush", 8.9);
            //student.Display();

            //Book
            //EBook book = new EBook();
            //book.SetDetails("978123456789", "C# Programming", "John Smith");
            //book.Display();

            //Bank Account
            //SavingsAccount account = new SavingsAccount();
            //account.SetDetails("ACC1001", "Ayush", 50000);
            //account.Display();

            //Employee
            Manager manager = new Manager();
            manager.SetDetails(501, "IT", 75000);
            manager.Display();
        }
    }
}
