using System;

namespace SingletonBasics
{
    public sealed class ThreadSafetySingleton
    {
        private static int counter = 0;
        private static ThreadSafetySingleton instance = null;
        private static readonly object obj = new object();
        public static ThreadSafetySingleton GetInstance
        {
            get
            {
                /*Double check locking*/
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new ThreadSafetySingleton();
                    }
                }
                return instance;
            }
        }
        /*
         * Private constructors ensures that object is not instantiated
         * other than within the class itself
         */
        private ThreadSafetySingleton()
        {
            counter++;
            Console.WriteLine($"Counter value for created instances: {counter}");
        }

        /* 
         * Public method which can be invoked trough singletin instance 
         */
        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
