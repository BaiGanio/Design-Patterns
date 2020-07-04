namespace DataSaviour
{
    // Option 2. Client code that uses an external data source.
    // SalaryManager objects neither know nor care about data
    // storage specifics. They work with a pre-configured data
    // source received from the app configurator.
    class SalaryManager
    {
        private readonly IDataSource _source;

        public SalaryManager(IDataSource source)
        {
            _source = source;
        }

        public string LoadSalaries()
        {
            return "";
        }

        public void SaveSalaries()
        {

        }
    }
}
