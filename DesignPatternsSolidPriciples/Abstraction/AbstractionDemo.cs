using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSolidPriciples.Abstraction
{
    public class AbstractionDemo
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending Email");
            Authenticate();
            ConnectServer();
            DisConnect();

        }
        
        private void Authenticate()
        {
            Console.WriteLine("Authenticate");
        } 
        private void ConnectServer()
        {
            Console.WriteLine("Conected to server");
        }

        private void DisConnect() {
            Console.WriteLine("DisConnected");
        }

    }
}
