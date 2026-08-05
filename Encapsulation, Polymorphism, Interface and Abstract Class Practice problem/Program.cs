using System;
using System.Collections.Generic;

namespace Encapsulation__Polymorphism__Interface_and_Abstract_Class_Practice_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Question 1 : Employee Management =====");

            List<Employee> employees = new List<Employee>();
            employees.Add(new FullTimeEmployee(101, "Ali", 50000));
            employees.Add(new PartTimeEmployee(102, "Sara", 0, 80, 300));

            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
            }

            Console.WriteLine("\n===== Question 2 : E-Commerce =====");

            List<Product> products = new List<Product>();
            products.Add(new Electronics(101, "Laptop", 60000));
            products.Add(new Clothing(102, "T-Shirt", 2000));
            products.Add(new Groceries(103, "Rice", 1000));

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.CalculateDiscount());
            }

            Console.WriteLine("\n===== Question 3 : Vehicle Rental =====");

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car("PB10A1234", 1500));
            vehicles.Add(new Bike("PB10B5678", 500));
            vehicles.Add(new Truck("PB10C9999", 3000));

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.CalculateRentalCost(5));
            }

            Console.WriteLine("\n===== Question 4 : Banking =====");

            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new SavingsAccount("SB101", "Ali", 50000));
            accounts.Add(new CurrentAccount("CA201", "Sara", 70000));

            foreach (BankAccount account in accounts)
            {
                Console.WriteLine(account.CalculateInterest());
            }

            Console.WriteLine("\n===== Question 5 : Library =====");

            List<LibraryItem> items = new List<LibraryItem>();
            items.Add(new Book(1, "C#", "John"));
            items.Add(new Magazine(2, "Tech", "Smith"));
            items.Add(new DVD(3, "Avengers", "Marvel"));

            foreach (LibraryItem item in items)
            {
                Console.WriteLine(item.GetLoanDuration());
            }

            Console.WriteLine("\n===== Question 6 : Food Delivery =====");

            List<FoodItem> foods = new List<FoodItem>();
            foods.Add(new VegItem("Pizza", 250, 2));
            foods.Add(new NonVegItem("Burger", 180, 3));

            foreach (FoodItem food in foods)
            {
                Console.WriteLine(food.CalculateTotalPrice());
            }

            Console.WriteLine("\n===== Question 7 : Hospital =====");

            List<Patient> patients = new List<Patient>();
            patients.Add(new InPatient(1, "Ali", 35, 5));
            patients.Add(new OutPatient(2, "Sara", 28));

            foreach (Patient patient in patients)
            {
                Console.WriteLine(patient.CalculateBill());
            }

            Console.WriteLine("\n===== Question 8 : Ride Hailing =====");

            Console.ReadKey();
        }
    }
}