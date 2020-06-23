namespace LogisticsManagement
{
    class SeaLogistics : LogisticsFactory
    {
        public override ITransportService CreateTransport()
        {
            return new ShipDelivery();
        }
    }
}
