using System;
using System.Text;
using System.Threading;
using WeatherStation.Observers;

namespace WeatherStation
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            WeatherData wd = new WeatherData();
            ConditionDisplay conditionDisplay = new ConditionDisplay(wd);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(wd);
            ForecastDisplay forecastDisplay = new ForecastDisplay(wd);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(wd);

            int _4days = 4;
            for (int i = 0; i < _4days; i++)
            {

                double[] measurements = GetRandomMeasurements();


                wd.SetMeasurements(measurements[0], measurements[1], measurements[2]);
                Console.WriteLine("----------------------------------------------------------------------------");
            }
            Console.WriteLine();
        }

        private static double[] GetRandomMeasurements()
        {
            double[] measurements = new double[3];
            Random rnd = new Random();
            for (int j = 0; j < measurements.Length; j++)
            {
                measurements[j] = rnd.NextDouble(0, 100);
                Thread.Sleep(100);
            }
            return measurements;
        }
    }
    public static class Utils
    {
        public static double NextDouble(this Random random, double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }

}
