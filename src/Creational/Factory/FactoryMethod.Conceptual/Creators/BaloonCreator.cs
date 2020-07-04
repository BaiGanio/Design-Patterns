namespace FactoryMethod.Conceptual
{
    class BaloonCreator : CreatorOfStuffs
    {
        public override Product GetFactoryProduct()
        {
            return new Baloon();
        }
    }
}
