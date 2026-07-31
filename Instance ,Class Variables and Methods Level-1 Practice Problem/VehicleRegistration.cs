using System;
using System.Collections.Generic;
using System.Text;

namespace Java_Instance__Class_Variables_and_Methods_Level_1_Practice_Problem
{
    internal class VehicleRegistration
    {
        private string ownerName;
        private string vehicleType;
        private static double registrationFee=500;

        public VehicleRegistration(string ownerName,string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        public void DisplayVehicleDetails()
        {
            Console.WriteLine("The Owner is : " + ownerName);
            Console.WriteLine("The vehicle Type is : " + vehicleType);
            Console.WriteLine("The registartion fees is : " + registrationFee);
        }

        public static void UpdateRegistrationFee(int newregistrationFee)
        {
            registrationFee = newregistrationFee;
        }
    }
}
