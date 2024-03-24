using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Exceptions;
using TicketBookingSystem.Models;
using TicketBookingSystem.Services;

namespace TicketBookingSystem.Repository
{
    internal class BookingSystemServiceProviderImpl:IBookingSystemServiceProvider
    {
        private Event[] events;
        public static List<Booking> bookings = new List<Booking>();

   
        //It return event details as string
        public string[] GetEventDetails(Event evnt)
        {
               return new string[] { evnt.EventName, evnt.EventDate.ToString(), evnt.EventTime.ToString(), evnt.Venue.VenueName };
        }

        public int GetAvailableNoOfTickets(Event evnt)
        {
            return evnt.AvailableSeats;
        }

        public void CalculateBookingCost(int numTickets, Event evnt)
        {
            decimal totalCost = numTickets * evnt.TicketPrice;
            Console.WriteLine($"Total cost for booking {numTickets} tickets: {totalCost}");
        }


        void IBookingSystemServiceProvider.BookTickets(string eventName, int numTickets, Customer[] customers, Event[] events)
        {
            foreach (Event evnt in events)
            {
                if (evnt.EventName == eventName)
                {
                    if (numTickets <= evnt.AvailableSeats)
                    {
                        for (int i = 0; i < numTickets; i++)
                        {
                            if (customers.Length > i)
                            {
                                Booking booking = new Booking(customers, evnt, numTickets);
                                bookings.Add(booking);
                                Console.WriteLine($"Ticket booked for customer: {customers[i].CustomerName} with id {booking.BookingId}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough available seats.");
                    }
                    break;
                }
            }
        }

        void IBookingSystemServiceProvider.CancelBooking(int bookingId, Event[] events)
        {
            // Find the booking using id
            Booking bookingToRemove = bookings.Find(b => b.BookingId == bookingId);

            if (bookingToRemove != null)
            {
                // Remove the booking from booking List
                bookings.Remove(bookingToRemove);

                // Update the available seats
                bookingToRemove.Event.AvailableSeats += bookingToRemove.NumTickets;

                Console.WriteLine($"Booking with ID {bookingId} canceled successfully.");
            }
            else
            {
                throw new InvalidBookingIDException("Invalid booking ID.");
            }
        }

        void IBookingSystemServiceProvider.GetBookingDetails(int bookingId, Event[] events)
        {
            Booking bookingDetail = bookings.Find(b => b.BookingId == bookingId);
            if (bookingDetail != null)
            {
                Console.WriteLine($"Booking Id: {bookingDetail.BookingId}\nBooking Date: {bookingDetail.BookingDate}\nNumber of Tickets: {bookingDetail.NumTickets}");

                //Find the event associated with the booking
                Event associatedEvent = events.FirstOrDefault(e => e.EventName == bookingDetail.Event.EventName);
                if (associatedEvent != null)
                {
                    // Print event details
                    Console.WriteLine($"Event Name: {associatedEvent.EventName}\nEvent Date: {associatedEvent.EventDate}\nEvent Time: {associatedEvent.EventTime}\nVenue: {associatedEvent.Venue.VenueName}");
                }
                else
                {
                    Console.WriteLine("Associated event not found.");
                }
            }
            else
            {
                Console.WriteLine($"Booking with ID {bookingId} not found.");
            }
        }

        Event[] IBookingSystemServiceProvider.CreateHardcodedEvents()
        {
            // default events
            Event event1 = new Event("IPL", new DateTime(2024,03,22), TimeSpan.FromHours(18), new Venue("Chepauk Stadium", "Beach Street, Chennai"), 15000, 15000, 2500.0m, EventType.Sports);
            Event event2 = new Event("One Piece Red", new DateTime(2024, 04, 20), TimeSpan.FromHours(19), new Venue("PVR Cinemas", "Nexus Vijaya Mall"), 150, 150, 250.0m, EventType.Movie);
            Event event3 = new Event("Music Realease", new DateTime(2024, 03, 29), TimeSpan.FromHours(20), new Venue("EVP ENTERPRISE", "Ponnamlaee"), 1200, 1200, 3000.0m, EventType.Concert);

            events = new Event[] { event1, event2, event3 };

            return events;
        }
    }
}
