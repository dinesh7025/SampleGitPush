namespace TicketBookingSystem.Exceptions
{
    public class EventNotFoundException : Exception
    {
        public EventNotFoundException()
        {

        }
        public EventNotFoundException(string message)
        : base(message)
        {
        }
    }
}