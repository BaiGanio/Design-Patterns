using System;
using System.Text;

namespace WeatherStation
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            WeatherData wd = new WeatherData();
            wd.MeasurementsChanged();

            Console.WriteLine();
        }
    }
}
