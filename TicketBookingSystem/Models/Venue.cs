using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.Models
{
    internal class Venue
    {
        public string VenueName { get; set; }
        public string Address { get; set; }
        //Default constructor
        public Venue()
        {
            VenueName = "";
            Address = "";
        }
        //Overloaded constructor
        public Venue(string venueName, string address)
        {
            VenueName = venueName;
            Address = address;
        }
       //Display venue details
        public void DisplayVenueDetails()
        {
            Console.WriteLine("Venue Name: " + VenueName);
            Console.WriteLine("Address: " + Address);
        }

    }
}
