namespace FactoryMethod.Conceptual
{
    // Concrete Products provide various implementations of the Product
    // interface.
    class Car : Product
    {
        public override string Describe()
        {
            return "{Result of Product1 is a car!}";
        }
    }
}
