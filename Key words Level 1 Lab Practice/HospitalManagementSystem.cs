using System;
using System.Collections.Generic;
using System.Text;

namespace Key_words_Level_1_Lab_Practice
{
    internal class Patient
    {
        public static string HospitalName = "City Hospital";
        private static int totalPatients = 0;

        public readonly int PatientID;

        public string Name;
        public int Age;
        public string Ailment;

        public Patient(int PatientID, string Name, int Age, string Ailment)
        {
            this.PatientID = PatientID;
            this.Name = Name;
            this.Age = Age;
            this.Ailment = Ailment;
            totalPatients++;
        }

        public void Display()
        {
            Console.WriteLine("Hospital Name : " + HospitalName);
            Console.WriteLine("Patient ID : " + PatientID);
            Console.WriteLine("Patient Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Ailment : " + Ailment);
        }

        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients : " + totalPatients);
        }

        public static void display()
        {
            Patient patient = new Patient(101, "Ayush", 21, "Fever");

            if (patient is Patient)
            {
                patient.Display();
            }

            GetTotalPatients();
        }
    }
}
