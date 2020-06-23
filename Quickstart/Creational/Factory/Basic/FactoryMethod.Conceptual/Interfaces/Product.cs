namespace FactoryMethod.Conceptual
{
    /* The Product interface declares the operations that all concrete products must implement. */
    abstract class Product
    {
        public string Name { get; set; }
        public abstract string Describe();
    }
}
