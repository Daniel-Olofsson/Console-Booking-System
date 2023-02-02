using System;
using System.Collections.Generic;

namespace BookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // var for class obj
            int userID = 0;
            int bookID = 0;
            var inputHandler = new HandleBooking();
            var userOne = new Person("Daniel", "Olofsson", userID++);
            var userTwo = new Person("Hades", "kattson", userID++);
            DateTime oneHourMeeting = new DateTime(2023, 02, 14, 10, 0, 0);
            DateTime twoHoursMeeting = new DateTime(2023, 02, 14, 13, 0, 0);
            
            //skapar ett booking obj med hjälp av CreateBooking funktionen
            inputHandler.CreateBooking(bookID++, DateTime.Now, DateTime.Now.AddHours(2), "Survey", userOne);
            inputHandler.CreateBooking(bookID++, DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(3), "Conference", userTwo);

            inputHandler.CreateBooking(bookID++, oneHourMeeting, oneHourMeeting.AddHours(1), "EC Meeting", userOne);
            inputHandler.CreateBooking(bookID++, twoHoursMeeting, twoHoursMeeting.AddHours(2), "Hemtenta", userTwo);
            //Deletes booking med id
            inputHandler.CancelBooking(1);

            //gets bookings
            var bookings = inputHandler.GetBookings();
            //loopar fram data från bookings
            foreach (var bookingData in bookings)
            {
                Console.WriteLine($"Booking ID: {bookingData.Id}");
                Console.WriteLine($"Start Time: {bookingData.StartTime}");
                Console.WriteLine($"End Time: {bookingData.EndTime}");
                Console.WriteLine($"Description: {bookingData.Description}");
                Console.WriteLine($"Booked by: {bookingData.BookedBy.FirstName} {bookingData.BookedBy.LastName}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
