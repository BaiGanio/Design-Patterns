namespace FactoryMethod.Conceptual
{
    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
    class CarCreator : CreatorOfStuffs
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Product GetFactoryProduct()
        {
            return new Car();
        }
    }
}
