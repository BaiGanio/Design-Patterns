namespace DataSaviour
{
    // The component interface defines operations that can be
    // altered by decorators.
    interface IDataSource
    {
        void WriteData(string data);
        string ReadData();
    }
}
