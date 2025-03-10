
using System;

namespace DesignPatternsSolidPriciples.Coupling{

    public class Order
    {

        private readonly INotification _notification;

        public Order(INotification notification)
        {
            _notification=notification;
    
        }

        // public void PlaceOrder(){

        // ///Tight coupling using the nnew keyword to ccreate an instance of an Email class
        //     EmailSender sendEmail= new EmailSender();
        //     sendEmail.SendEmail("Order placed sucessfully");


        // }

        public void PlaceOrder(){

                _notification.SendNotification("Order Placed");

        }


    }


}