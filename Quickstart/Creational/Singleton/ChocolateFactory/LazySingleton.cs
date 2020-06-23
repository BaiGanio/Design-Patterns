using System;

namespace ChocolateFactory
{
    /* Sealed restrict the inheritance */
    public sealed class LazySingleton
    {
        /*Lazy objects are thread safe*/
        private static readonly Lazy<LazySingleton> instance = new Lazy<LazySingleton>(() => new LazySingleton());
        public static LazySingleton GetInstance
        {
            get { return instance.Value; }
        }
        /* Private constructors ensures that object is not instantiated other than within the class itself */
        private LazySingleton() { }

    }
}

/*
 * Lazy loading improves the performance.
 * Avoid unnecessary load.
 * Reduces memory footprint at startup.
 * Faster application load 
 */

/* 
 * Eager loading  want pre-instantination of the object
 * Used in lower memory footprints
 */
