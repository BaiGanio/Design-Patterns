namespace MailDelivery
{
    class Airplane : IMailDeliveryService
    {
        public string DeliverMail()
        {
            return "The mail is delivered by airplane.";
        }
    }
}
