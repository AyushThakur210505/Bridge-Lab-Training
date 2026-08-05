using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation__Polymorphism__Interface_and_Abstract_Class_Practice_problem
{
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;
        private string diagnosis;
        private List<string> medicalHistory = new List<string>();

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Diagnosis
        {
            set { diagnosis = value; }
        }

        protected List<string> MedicalHistory
        {
            get { return medicalHistory; }
        }

        public Patient(int id, string name, int age)
        {
            PatientId = id;
            Name = name;
            Age = age;
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("Patient ID : " + PatientId);
            Console.WriteLine("Name       : " + Name);
            Console.WriteLine("Age        : " + Age);
        }
    }

    class InPatient : Patient, IMedicalRecord
    {
        private int days;

        public InPatient(int id, string name, int age, int days)
            : base(id, name, age)
        {
            this.days = days;
        }

        public override double CalculateBill()
        {
            return days * 3000;
        }

        public void AddRecord(string record)
        {
            MedicalHistory.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (string record in MedicalHistory)
            {
                Console.WriteLine(record);
            }
        }
    }

    class OutPatient : Patient, IMedicalRecord
    {
        public OutPatient(int id, string name, int age)
            : base(id, name, age)
        {
        }

        public override double CalculateBill()
        {
            return 800;
        }

        public void AddRecord(string record)
        {
            MedicalHistory.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (string record in MedicalHistory)
            {
                Console.WriteLine(record);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>();

            InPatient p1 = new InPatient(1, "Ali", 35, 5);
            p1.AddRecord("Admitted for surgery");

            OutPatient p2 = new OutPatient(2, "Sara", 28);
            p2.AddRecord("General Checkup");

            patients.Add(p1);
            patients.Add(p2);

            foreach (Patient patient in patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine("Bill : " + patient.CalculateBill());

                if (patient is IMedicalRecord record)
                {
                    record.ViewRecords();
                }

                Console.WriteLine("----------------------------");
            }

            Console.ReadKey();
        }
    }
}
