using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Models;
using TicketBookingSystem.Services;

namespace TicketBookingSystem.Repository
{
    internal class EventServiceProviderImpl : IEventServiceProvider
    {
        Event IEventServiceProvider.CreateEvent(string eventName, DateTime date, TimeSpan time, int totalSeats, int availableSeats, decimal ticketPrice, EventType eventType, Venue venue)
        {
            Event newEvent = new Event(eventName, date, time, venue, totalSeats, totalSeats, ticketPrice, eventType);
            return newEvent;
        }

        int IEventServiceProvider.GetAvailableNoOfTickets(Event evnt)
        {
            return evnt.AvailableSeats;
        }

        void IEventServiceProvider.GetEventDetails(Event events)
        {
            
           /* {
                PrintEventDetails(e);
            }*/
        }
        public void PrintEventDetails(Event evnt)
        {
            Console.WriteLine($"Event Name: {evnt.EventName}");
            Console.WriteLine($"Event Date: {evnt.EventDate}");
            Console.WriteLine($"Event Time: {evnt.EventTime}");
            Console.WriteLine($"Venue: {evnt.Venue.VenueName}");
            Console.WriteLine();
        }

    }
}
