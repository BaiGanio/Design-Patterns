using System;
using System.Collections.Generic;
using System.Threading;
using Utils;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();
            RegisterObservers(wd);

            List<WeatherForecast> forecastData = GetWeatherForecastData();
            foreach (var forecast in forecastData)
            {
                //wd.SetMeasurements(forecast.TemperatureC, forecast.Humidity, forecast.Pressure, null, DateTime.Now.AddDays(1));                
                wd.SetMeasurements(forecast);
            }
            Console.WriteLine();
        }

        private static void RegisterObservers(WeatherData wd)
        {
            _ = new ConditionDisplay(wd);
            _ = new StatisticsDisplay(wd);
            _ = new ForecastDisplay(wd);
            // HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(wd);
        }

        private static List<WeatherForecast> GetWeatherForecastData()
        {
            var data = new List<WeatherForecast>();
            var rng = new Random();
            string[] Summaries =
                new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

            Console.Write("Please wait! Collecting data");
            for (int i = 0; i < 7; i++)
            {
                var forecast = new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = rng.Next(-20, 55),
                    Humidity = RandomGeneratorUtils.NextDouble(rng, 0, 100),
                    Pressure = RandomGeneratorUtils.NextDouble(rng, 0, 100),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                };
                data.Add(forecast);
                Console.Write(".");
                Thread.Sleep(1000);
            };
            Console.WriteLine();
            Console.WriteLine();
            return data;
        }
    }
}
