using System;
using System.Threading;

namespace MailDelivery
{
    class MailDeliveryManager
    {
        public void DoJob()
        {
            Console.WriteLine("Manager: Request for air delivery!");
            DoWork(new AirDelivery());
            Console.WriteLine("-------------------------------");

            Thread.Sleep(2000);

            Console.WriteLine("Manager: Request for ground delivery by train!");
            DoWork(new GroundDelivery(), TransportType.Train);
            Console.WriteLine("-------------------------------");

            Thread.Sleep(2000);

            Console.WriteLine("Manager: Request for ground delivery by truck!");
            DoWork(new GroundDelivery(), TransportType.Truck);
            Console.WriteLine("-------------------------------");

            Thread.Sleep(2000);

            Console.WriteLine("Manager: Request for air delivery by cargo plane!");
            DoWork(new AirDelivery(), TransportType.CargoPlane);
        }

        // The DoWork() works with an instance of a concrete creator, albeit
        // through its base interface. As long as the LogisticsManager keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void DoWork(MailDeliveryFactory factory)
        {
            var transportService = factory.PlanDelivery();
            Console.WriteLine($"Not aware of the requested transportation service, but will do the delivery!");
            Console.WriteLine($"{transportService.DeliverMail()}");
        }

        private void DoWork(MailDeliveryFactory factory, TransportType transport)
        {
            var transportService = factory.PlanDelivery(transport);
            Console.WriteLine("Not aware of the requested transportation service, but will do the delivery!");
            Console.WriteLine($"{transportService.DeliverMail()}");
        }
    }
}
