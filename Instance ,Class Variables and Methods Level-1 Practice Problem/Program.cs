using System;

namespace Java_Instance__Class_Variables_and_Methods_Level_1_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductInventory.cs

            //ProductInventory product = new ProductInventory("Laptop", 150000);
            //ProductInventory product1 = new ProductInventory("Cream", 250);
            //ProductInventory product2 = new ProductInventory("Oil", 100);

            //product.DisplayProductDetails();
            //Console.WriteLine();

            //product1.DisplayProductDetails();
            //Console.WriteLine();

            //product2.DisplayProductDetails();
            //Console.WriteLine();

            //ProductInventory.DisplayTotalProducts();




            //OnlineCourseManagement.cs

            //OnlineCourseManagement course = new OnlineCourseManagement("CSE", 12, 150000);
            //OnlineCourseManagement course1 = new OnlineCourseManagement("BCA", 6, 50000);
            //OnlineCourseManagement course2 = new OnlineCourseManagement("MCA", 18, 190000);

            //course.DisplayCourseDetails();
            //Console.WriteLine();

            //course1.DisplayCourseDetails();
            //Console.WriteLine();

            //course2.DisplayCourseDetails();
            //Console.WriteLine();

            //OnlineCourseManagement.UpdateInstitutionName("Thakur University");

            //OnlineCourseManagement course3 = new OnlineCourseManagement("Nurshing", 24, 155000);

            //course3.DisplayCourseDetails();
            //Console.WriteLine();




            //VehicleRegistration.cs

            VehicleRegistration vehicle = new VehicleRegistration("Ayush", "4 Wheeler");
            VehicleRegistration vehicle1 = new VehicleRegistration("Thakur", "2 Wheeler");
            VehicleRegistration vehicle2 = new VehicleRegistration("Saurav", "4 Wheeler");

            vehicle.DisplayVehicleDetails();
            Console.WriteLine();

            vehicle1.DisplayVehicleDetails();
            Console.WriteLine();

            vehicle2.DisplayVehicleDetails();
            Console.WriteLine();

            VehicleRegistration.UpdateRegistrationFee(1000);

            vehicle.DisplayVehicleDetails();
            Console.WriteLine();
        }
    }
}
