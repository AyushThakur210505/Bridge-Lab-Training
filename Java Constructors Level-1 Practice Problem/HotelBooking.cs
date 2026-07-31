using System;
using System.Collections.Generic;
using System.Text;

namespace Java_Constructors_Level_1_Practice_Problem
{
    internal class HotelBooking
    {
        private string guestName;
        private string roomType;
        private int NoOfNights;

        public HotelBooking()
        {
            guestName = "Unkown";
            roomType = "Unkown";
            NoOfNights = 0;

        }

        public HotelBooking(string guestName, string roomType, int noOfNights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.NoOfNights = noOfNights;
        }

        public HotelBooking(HotelBooking other)
        {
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.NoOfNights = other.NoOfNights;
        }

        public void display()
        {
            Console.WriteLine("Name of the Guest : " + guestName);
            Console.WriteLine("Room Type : " + roomType);
            Console.WriteLine("Nights they are going to Stay : " + NoOfNights);
            Console.WriteLine();
        }
    }
}
