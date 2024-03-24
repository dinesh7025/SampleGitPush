using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.Models
{
    internal class Concert:Event
    {
        public string Artist { get; set; }
        public string Type { get; set; }
        //Default constructor
        public Concert() : base()
        {
            Artist = "";
            Type = "";
        }
        // Overloaded constructor
        public Concert(string eventName, DateTime eventDate, TimeSpan eventTime, Venue venue, int totalSeats, int availableSeats, decimal ticketPrice, EventType eventType, string artist, string type)
            : base(eventName, eventDate, eventTime, venue, totalSeats, availableSeats, ticketPrice, eventType)
        {
            Artist = artist;
            Type = type;
        }
        // Display concert details
        public void DisplayConcertDetails()
        {
            base.DisplayEventDetails();
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Type: " + Type);
        }
    }
}
