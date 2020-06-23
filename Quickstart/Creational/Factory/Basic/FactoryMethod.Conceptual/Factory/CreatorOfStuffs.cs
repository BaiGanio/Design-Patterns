namespace FactoryMethod.Conceptual
{
    // The Creator class declares the factory method that is supposed to return
    // an object of a Product class. The Creator's subclasses usually provide
    // the implementation of this method.
    abstract class CreatorOfStuffs
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract Product GetFactoryProduct();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string GetProduct()
        {
            // Call the factory method to create a Product object.
            Product product = GetFactoryProduct();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with "
                + product.Describe();

            return result;
        }
    }
}
