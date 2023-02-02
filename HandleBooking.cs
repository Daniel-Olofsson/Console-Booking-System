using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    public class HandleBooking
    {
        //skapar en lista
        private List<Booking> _bookings;

        public HandleBooking()
        {
            _bookings = new List<Booking>();
        }

        public void CreateBooking(int id, DateTime startTime, DateTime endTime, string description, Person bookedBy)
        {
            //instansiera ett booking obj lägger till det i bookings listan
            var booking = new Booking(id, startTime, endTime, description, bookedBy);
            _bookings.Add(booking);
        }

        public List<Booking> GetBookings()
        {
            return _bookings;
        }

        public void CancelBooking(int id)
        {
            Booking bookingToCancel = null;
            foreach (var booking in _bookings)
            {
                if (booking.Id == id)
                {
                    bookingToCancel = booking;
                    break;
                }
            }
            if (bookingToCancel != null)
            {
                _bookings.Remove(bookingToCancel);
            }
        }
    }
     

}
