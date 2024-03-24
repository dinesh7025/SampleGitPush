using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Models;

namespace TicketBookingSystem.Services
{
    internal interface IEventServiceProvider
    {
        Event CreateEvent(string eventName, DateTime date, TimeSpan time, int totalSeats,int availableSeats, decimal ticketPrice, EventType eventType, Venue venue);
        void GetEventDetails(Event evnt);
        int GetAvailableNoOfTickets(Event evnt);
    }
}
