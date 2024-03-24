using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.Models
{
    internal class Customer
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //Default constructor
        public Customer()
        {
            CustomerName = "";
            Email = "";
            PhoneNumber = "";
        }
        //Overloaded constructor
        public Customer(string customerName, string email, string phoneNumber)
        {
            CustomerName = customerName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        //Display customer details
        public void DisplayCustomerDetails()
        {
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone Number: " + PhoneNumber);
        }
    }
}
