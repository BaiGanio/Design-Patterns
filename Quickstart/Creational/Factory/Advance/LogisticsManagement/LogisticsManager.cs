using System;
using System.Threading;

namespace LogisticsManagement
{
    class LogisticsManager
    {
        public void ExecuteRequestedServices()
        {
            Console.WriteLine("Manager: Request for road delivery!");
            DoWork(new RoadLogistics());
            Console.WriteLine("-------------------------------");

            Thread.Sleep(2000);

            Console.WriteLine("Manager: Request for sea delivery!");
            DoWork(new SeaLogistics());
            Console.WriteLine("-------------------------------");

            Thread.Sleep(2000);

            Console.WriteLine("Manager: Request for air delivery!");
            DoWork(new AirLogistics());
        }

        // The DoWork() works with an instance of a concrete creator, albeit
        // through its base interface. As long as the LogisticsManager keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void DoWork(LogisticsFactory factory)
        {
            var transportService = factory.PlanTransport();
            Console.WriteLine("Not aware of the requested transportation service, but will do the delivery!");
            Console.WriteLine($"{transportService.DeliverGoods()}");
        }
    }
}
