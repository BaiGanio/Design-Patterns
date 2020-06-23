namespace LogisticsManagement
{
    abstract class LogisticsFactory
    {
        public ITransportService PlanTransport()
        {
            return CreateTransport();
        }

        public abstract ITransportService CreateTransport();
    }
}
