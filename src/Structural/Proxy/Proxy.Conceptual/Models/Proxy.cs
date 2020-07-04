using DP.Common.Helpers;
using System;

namespace Proxy.Conceptual
{
    // The Proxy has an interface identical to the RealSubject.
    class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        // The most common applications of the Proxy pattern are lazy loading,
        // caching, controlling the access, logging, etc. A Proxy can perform
        // one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealSubject object.
        public void SendHttpRequest(string url)
        {
            if (CheckAccess())
            {
                _realSubject = new RealSubject();
                _realSubject.SendHttpRequest(url);

                LogAccess();
            }
        }

        public double Subsctract(double value1, double value2)
        {
            double result = 0;
            if (CheckAccess())
            {
                _realSubject = new RealSubject();
                result = _realSubject.Subsctract(value1, value2);

                LogAccess();
            }
            return result;
        }

        private bool CheckAccess()
        {
            // Some real checks should go here.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        private void LogAccess()
        {
            //var st = new StackTrace();

            //Console.WriteLine($"{st.GetFrame(0).GetMethod().Name}: I was called by delegate...");

            FileLogger fl = new FileLogger($"../../../proxy-{DateTime.Now.Ticks}.log");
            Console.WriteLine("Proxy: Logging the time of request.");
            fl.LogInformational(DateTime.Now.ToShortTimeString());
        }
    }
}
