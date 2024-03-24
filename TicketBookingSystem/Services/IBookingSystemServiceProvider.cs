using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Models;

namespace TicketBookingSystem.Services
{
    internal interface IBookingSystemServiceProvider
    {
        void CalculateBookingCost(int numTickets, Event evnt);
        void BookTickets(string eventName, int numTickets, Customer[] customers, Event[] events);
        void CancelBooking(int bookingId, Event[] events);
        void GetBookingDetails(int bookingId, Event[] events);
        Event[] CreateHardcodedEvents();
    }
}
