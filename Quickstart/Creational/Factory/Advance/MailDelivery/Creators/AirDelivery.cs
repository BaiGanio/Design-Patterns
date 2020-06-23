using System;

namespace MailDelivery
{
    class AirDelivery : MailDeliveryFactory
    {
        public override IMailDeliveryService LoadMail(TransportType? transport)
        {
            return transport switch
            {
                TransportType.CargoPlane => throw new Exception("Still in progress!!!"),
                TransportType.SuperSonicJet => throw new Exception("Still in progress!!!"),
                _ => new Airplane(),
            };
        }
    }
}
