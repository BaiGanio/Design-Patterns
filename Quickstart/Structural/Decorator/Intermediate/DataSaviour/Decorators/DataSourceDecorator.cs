namespace DataSaviour
{
    // The base decorator class follows the same interface as the
    // other components. The primary purpose of this class is to
    // define the wrapping interface for all concrete decorators.
    // The default implementation of the wrapping code might include
    // a field for storing a wrapped component and the means to
    // initialize it.
    abstract class DataSourceDecorator : IDataSource
    {
        protected IDataSource _source;

        public DataSourceDecorator(IDataSource source)
        {
            _source = source;
        }

        // Concrete decorators may call the parent implementation of
        // the operation instead of calling the wrapped object
        // directly. This approach simplifies extension of decorator
        // classes.
        public virtual string ReadData()
        {
            return _source.ReadData();
        }

        // The base decorator simply delegates all work to the
        // wrapped component. Extra behaviors can be added in
        // concrete decorators.
        public virtual void WriteData(string data)
        {
            _source.WriteData(data);
        }
    }
}
