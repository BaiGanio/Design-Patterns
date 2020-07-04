using System;

namespace Proxy.Conceptual
{
    // The RealSubject contains some core business logic. Usually, RealSubjects
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data. A Proxy can solve these issues
    // without any changes to the RealSubject's code.
    class RealSubject : ISubject
    {
        public void SendHttpRequest(string url)
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }

        public double Subsctract(double value1, double value2)
        {
            Console.WriteLine("RealSubject: Handling Substract.");
            return value1 - value2;
        }
    }
}
