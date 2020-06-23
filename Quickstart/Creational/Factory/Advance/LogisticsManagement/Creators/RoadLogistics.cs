namespace LogisticsManagement
{
    class RoadLogistics : LogisticsFactory
    {
        public override ITransportService CreateTransport()
        {
            return new TruckDelivery();
        }
    }
}
