using System;

namespace MailDelivery
{
    class Train : IMailDeliveryService
    {
        public string DeliverMail()
        {
            return "The mail is delivered by train.";
        }
    }
}
