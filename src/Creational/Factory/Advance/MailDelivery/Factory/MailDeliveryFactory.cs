namespace MailDelivery
{
    abstract class MailDeliveryFactory
    {
        public IMailDeliveryService PlanDelivery(TransportType? transport = null)
        {
            return LoadMail(transport);
        }

        public abstract IMailDeliveryService LoadMail(TransportType? transport);
    }
}
