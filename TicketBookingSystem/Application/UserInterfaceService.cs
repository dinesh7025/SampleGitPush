using TicketBookingSystem.Exceptions;
using TicketBookingSystem.Models;
using TicketBookingSystem.Repository;
using TicketBookingSystem.Services;

namespace TicketBookingSystem.Application
{
    internal class UserInterfaceService
    {
        public readonly IEventServiceProvider eventServiceProvider;
        public readonly IBookingSystemServiceProvider bookingSystemServiceProvider;
        public Event[] events;

        public UserInterfaceService()
        {
            eventServiceProvider = new EventServiceProviderImpl();
            bookingSystemServiceProvider = new BookingSystemServiceProviderImpl();
            events = bookingSystemServiceProvider.CreateHardcodedEvents();
            
        }
        
        public void App()
        {
            // Your user interface logic goes here
            // For example:
            Console.WriteLine("Welcome to the Ticket Booking System!");

            string? userInput;
            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create Event");
                Console.WriteLine("2. Book Tickets");
                Console.WriteLine("3. Cancel Booking");
                Console.WriteLine("4. Booking Id Details");
                Console.WriteLine("5. Exit");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Three events 'IPL','One Piece','Music Realease' Redadded successfully.");
                        break;
                    case "2":
                        Console.Write("Enter the event name: ");
                        string eventname = Console.ReadLine();
                        Event evnt = events.FirstOrDefault(e => e.EventName == eventname);
                        if (evnt == null)
                        {
                            throw new EventNotFoundException("Event not found in the menu.");
                        }

                        // Prompt user for number of tickets
                        Console.Write("Enter the number of tickets: ");
                        int numTickets = int.Parse(Console.ReadLine());

                        // Prompt user for customer details
                        Console.WriteLine("Enter customer details:");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Phone Number: ");
                        string phoneNumber = Console.ReadLine();

                        // Create Customer object
                        Customer customer = new Customer(name, email, phoneNumber);

                        //covert to array
                        Customer[] arrayOfCustomer = new Customer[] { customer };

                        // Call the BookTickets method
                        bookingSystemServiceProvider.BookTickets(eventname, numTickets, arrayOfCustomer,events);
                        break;
                    case "3":
                        Console.WriteLine("Enter booking Id to cancel");
                        int idToRemove = Convert.ToInt32(Console.ReadLine());
                        bookingSystemServiceProvider.CancelBooking(idToRemove,events);
                        break;
                    case "4":
                        Console.WriteLine("Enter the Booking Id");
                        int id = Convert.ToInt32(Console.ReadLine());

                        bookingSystemServiceProvider.GetBookingDetails(id,events);
                        break;

                    case "5":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;


                }
            } while (userInput != "5");

        }
    }
}
