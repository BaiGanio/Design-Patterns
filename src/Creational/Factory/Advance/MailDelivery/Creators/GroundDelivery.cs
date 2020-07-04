using System;

namespace MailDelivery
{
    class GroundDelivery : MailDeliveryFactory
    {
        public override IMailDeliveryService LoadMail(TransportType? transport)
        {
            switch (transport)
            {
                case TransportType.Train:
                    return new Train();
                case TransportType.Truck:
                    return new Truck();
                default:
                    throw new Exception("You should specify ground delivery transport!");
            }
        }
    }
}
