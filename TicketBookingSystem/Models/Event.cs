using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.Models
{
    public enum EventType
    {
        Movie,
        Sports,
        Concert
    }
    internal class Event
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan EventTime { get; set; }
        public Venue Venue { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public decimal TicketPrice { get; set; }
        public EventType EventType { get; set; }

        //Default constructor
        public Event()
        {
            EventName = "";
            EventDate = DateTime.Now.Date;
            EventTime = DateTime.Now.TimeOfDay;
            Venue = new Venue();
            TotalSeats = 0;
            AvailableSeats = 0;
            TicketPrice = 0.0m;
            EventType = EventType.Movie;
        }
        //Overloaded constructor
        public Event(string eventName, DateTime eventDate, TimeSpan eventTime, Venue venue, int totalSeats, int availableSeats, decimal ticketPrice, EventType eventType)
        {
            EventName = eventName;
            EventDate = eventDate;
            EventTime = eventTime;
            Venue = venue;
            TotalSeats = totalSeats;
            AvailableSeats = availableSeats;
            TicketPrice = ticketPrice;
            EventType = eventType;
        }

        //Display event details
        public void DisplayEventDetails()
        {
            Console.WriteLine("Event Name: " + EventName);
            Console.WriteLine("Event Date: " + EventDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Event Time: " + EventTime.ToString(@"hh\:mm\:ss"));
            Console.WriteLine("Venue Name: " + Venue.VenueName);
            Console.WriteLine("Total Seats: " + TotalSeats);
            Console.WriteLine("Available Seats: " + AvailableSeats);
            Console.WriteLine("Ticket Price: " + TicketPrice);
            Console.WriteLine("Event Type: " + EventType);
        }

    }
}
