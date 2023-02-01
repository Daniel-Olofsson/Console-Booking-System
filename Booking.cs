using System;
using System.Collections.Generic;
namespace BookingSystem //Bookningssytemets namespace
{
    public class Booking
    {
        //unikt id för varje bookning, startid, sluttid, mötes innehåll, och använder mig av classen Person för att veta vem som bokade det.
        public int Id { get; set; } 
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public Person BookedBy { get; set; }

        //konstruktor
        public Booking(int id, DateTime startTime, DateTime endTime, string description, Person bookedBy)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
            BookedBy = bookedBy;
        }
    }

}



