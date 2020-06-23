using System;

namespace SingletonBasics
{
    /*
        Sealed restrict the inheritance         
     */
    public sealed class SingleThreatedSingleton
    {
        //private static double chocolateMixture = 570.25;
        private static int counter = 0;
        private static SingleThreatedSingleton instance = null;
        public static SingleThreatedSingleton GetInstance
        {
            get
            {
                /*
                 * Lazy initialization. Works fine in single threated inviorment
                 */
                if (instance == null)
                {
                    instance = new SingleThreatedSingleton();
                }
                return instance;
            }
        }
        /*
         * Private constructors ensures that object is not instantiated
         * other than within the class itself
         */
        private SingleThreatedSingleton()
        {
            counter++;
            Console.WriteLine($"Counter value for created instances: {counter}");
        }

        /* 
         * Public method which can be invoked trough singletin instance 
         */
        public void PrintDetails(string msg)
        {
            Console.WriteLine($"{msg} -> Chocolate instahnces: {counter}");
        }
    }
}
