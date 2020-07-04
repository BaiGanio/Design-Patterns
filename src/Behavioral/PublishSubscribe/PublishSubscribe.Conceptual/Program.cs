using PublishSubscribe.Conceptual.Models;
using System;

namespace PublishSubscribe.Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            PubBasicDemo();
            PubWithEventHandlerDemo();
        }

        private static void PubWithEventHandlerDemo()
        {
            //Initialize pub class object
            PubWithEventHandler p = new PubWithEventHandler();

            //register for OnChange event - Subscriber 1
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1! Value:" + e.Value);
            //register for OnChange event - Subscriber 2
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 2! Value:" + e.Value);

            //raise the event
            p.Raise();

            //After this Raise() method is called
            //all subscribers callback methods will get invoked

            Console.WriteLine("Press enter to terminate!");
            Console.ReadLine();
        }

        private static void PubBasicDemo()
        {
            //Initialize pub class object
            PubBasic p = new PubBasic();

            //register for OnChange event - Subscriber 1
            p.OnChange += () => Console.WriteLine("Subscriber 1!");
            //register for OnChange event - Subscriber 2
            p.OnChange += () => Console.WriteLine("Subscriber 2!");

            //raise the event
            p.Raise();

            //After this Raise() method is called
            //all subscribers callback methods will get invoked

            Console.WriteLine("Press enter to terminate!");
            Console.ReadLine();
        }
    }
}
