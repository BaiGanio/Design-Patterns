namespace LogisticsManagement
{
    class AirLogistics : LogisticsFactory
    {
        public override ITransportService CreateTransport()
        {
            return new AirplaneDelivery();
        }
    }
}
