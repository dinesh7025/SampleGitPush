using TicketBookingSystem.Application;
using TicketBookingSystem.Exceptions;

namespace TicketBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserInterfaceService userService = new UserInterfaceService();
                userService.App();
            }
            catch (EventNotFoundException ex)//If No such event in event[]
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidBookingIDException ex)//If no such Booking<List>
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Alert an Unknown error!: {ex.Message}");
            }
        }
    }
}
