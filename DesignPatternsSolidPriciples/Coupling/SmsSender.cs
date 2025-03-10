
namespace DesignPatternsSolidPriciples.Coupling
{

public class SmsSender:INotification
{
        public void SendNotification(string message)
        {
           Console.WriteLine($"SMS Message {message}");
        }
}


}