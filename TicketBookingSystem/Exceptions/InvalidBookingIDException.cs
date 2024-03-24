using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.Exceptions
{
    internal class InvalidBookingIDException : Exception
    {
        public InvalidBookingIDException()
        {
        }

        public InvalidBookingIDException(string message)
            : base(message)
        {
        }

    }
}
