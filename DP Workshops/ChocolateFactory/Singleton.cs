using System;

namespace ChocolateFactory
{
    /* Sealed restrict the inheritance */
    public sealed class Singleton
    {
        /*Lazy objects are thread safe*/
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance
        {
            get { return instance.Value; }
        }
        /* Private constructors ensures that object is not instantiated other than within the class itself */
        private Singleton() { }

    }
}

/*
 * Lazy loading improves the prformance.
 * Avoid unnecessary load.
 * Reduces memory footprint at startup.
 * Faster application load 
 */

/* 
 * Eager loading  want pre-instantination of the object
 * Used in lower memory footprints
 */
