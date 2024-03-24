using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.Models
{
    internal class Sports:Event
    {
        public string SportName { get; set; }
        public string TeamsName { get; set; }

        //Default constructor
        public Sports() : base()
        {
            SportName = "";
            TeamsName = "";
        }
        //Overloaded constructor
        public Sports(string eventName, DateTime eventDate, TimeSpan eventTime, Venue venue, int totalSeats, int availableSeats, decimal ticketPrice, EventType eventType, string sportName, string teamsName)
            : base(eventName, eventDate, eventTime, venue, totalSeats, availableSeats, ticketPrice, eventType)
        {
            SportName = sportName;
            TeamsName = teamsName;
        }
        //Display sports details
        public void DisplaySportDetails()
        {
            base.DisplayEventDetails();
            Console.WriteLine("Sport Name: " + SportName);
            Console.WriteLine("Teams Name: " + TeamsName);
        }
    }
}
