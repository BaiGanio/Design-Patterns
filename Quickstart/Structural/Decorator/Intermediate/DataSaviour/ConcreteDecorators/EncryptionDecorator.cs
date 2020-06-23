namespace DataSaviour
{
    // Concrete decorators must call methods on the wrapped object,
    // but may add something of their own to the result. Decorators
    // can execute the added behavior either before or after the
    // call to a wrapped object.
    internal class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource source)
            : base(source) { }

        public override string ReadData()
        {
            return base.ReadData();
        }

        public override void WriteData(string data)
        {
            base.WriteData(data);
        }
    }
}
