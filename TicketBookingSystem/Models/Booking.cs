using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.Models
{
    internal class Booking
    {
        private static int nextBookingId = 1;

        public int BookingId { get; }
        public Customer[] Customers { get; set; }
        public Event Event { get; set; }
        public int NumTickets { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime BookingDate { get; set; }
        //Default constructor
        public Booking()
        {
            BookingId = nextBookingId++;
            Customers = new Customer[0];
            Event = null;
            NumTickets = 0;
            TotalCost = 0.0m;
            BookingDate = DateTime.Now;
        }
        //Overloaded constructor
        public Booking(Customer[] customers, Event @event, int numTickets)
        {
            BookingId = nextBookingId++;
            Customers = customers;
            Event = @event;
            NumTickets = numTickets;
            TotalCost = numTickets*Event.TicketPrice;
            BookingDate = DateTime.Now.Date;
        }
        //Display booking details
        public void DisplayBookingDetails()
        {
            Console.WriteLine("Booking ID: " + BookingId);
            Console.WriteLine("Customers:");
            foreach (var customer in Customers)
            {
                customer.DisplayCustomerDetails();
            }
            Console.WriteLine("Event:");
            Event.DisplayEventDetails();
            Console.WriteLine("Number of Tickets: " + NumTickets);
            Console.WriteLine("Total Cost: " + TotalCost);
            Console.WriteLine("Booking Date: " + BookingDate.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
