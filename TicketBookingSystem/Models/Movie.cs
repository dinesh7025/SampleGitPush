namespace TicketBookingSystem.Models
{
    internal class Movie:Event
    {
        public string Genre { get; set; }
        public string ActorName { get; set; }
        public string ActressName { get; set; }

        // Default constructor
        public Movie() : base()
        {
            Genre = "";
            ActorName = "";
            ActressName = "";
        }

        // Overloaded constructor
        public Movie(string eventName, DateTime eventDate, TimeSpan eventTime, Venue venue, int totalSeats, int availableSeats, decimal ticketPrice, EventType eventType, string genre, string actorName, string actressName)
            : base(eventName, eventDate, eventTime, venue, totalSeats, availableSeats, ticketPrice, eventType)
        {
            Genre = genre;
            ActorName = actorName;
            ActressName = actressName;
        }

        // Display movie details
        public void DisplayMovieDetails()
        {
            base.DisplayEventDetails();
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Actor Name: " + ActorName);
            Console.WriteLine("Actress Name: " + ActressName);
        }
    }
}
