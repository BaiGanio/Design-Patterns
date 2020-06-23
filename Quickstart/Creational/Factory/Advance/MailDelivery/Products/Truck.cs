namespace MailDelivery
{
    class Truck : IMailDeliveryService
    {
        public string DeliverMail()
        {
            return "The mail is delivered by truck.";
        }
    }
}
