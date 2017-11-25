namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();
            wd.MeasurementsChanged();
        }
    }
}
