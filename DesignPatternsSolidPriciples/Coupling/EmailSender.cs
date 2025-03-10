
namespace DesignPatternsSolidPriciples.Coupling{



public class EmailSender:INotification
{
   

        public void SendNotification(string message)
        {
            Console.WriteLine($"EmailMessage{message}");
        }
    }
}