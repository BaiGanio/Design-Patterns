using DPWorkshops.Common;
using System;
using System.Collections.Generic;

/* Observer (Behavioral) DP */
namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cities = InitializeCitiesForecast();
            var forecasts = GetWeatherForecastData();

            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"{"WEATHER-FINDER",50}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"{"City",-20}| {"Date",-30}| {"Temperature "}| {"Summary",-20}|\n");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            for (int i = 0; i < cities.Count; i++)
            {
                var city = i == 0 ? cities[i].Name : "";
                Console.WriteLine(
                    $"{city,-20}| " +
                    $"{forecasts[i].Date.ToLongDateString(),-30}| " +
                    $"{forecasts[i].TemperatureC,-12:N2}| " +
                    $"{forecasts[i].Summary,-20}|"
                );
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }

        private static List<Station> InitializeCitiesForecast()
        {
            List<Station> cities = new List<Station>() 
            { 
                new Station { Name = "Amsterdam", OneWeekForecast = GetWeatherForecastData()},
                new Station { Name = "Plovdiv", OneWeekForecast = GetWeatherForecastData()},
                new Station { Name = "Buenos Aires"/*, ThreeWeeksForecast = GetWeatherThirtyWeeksForecast()*/},
                new Station { Name = "Tokyo"/*, ThreeWeeksForecast = GetWeatherThirtyWeeksForecast()*/},
                new Station { Name = "California"},
                new Station { Name = "Paris"},
                new Station { Name = "Mexico City"}
            };
            return cities;
        }

        private static List<WeatherForecast> GetWeatherForecastData()
        {
            var weeklyForecast = new List<WeatherForecast>();
            var rng = new Random();
            string[] Summaries =
                new[]
                {
                    "Freezing",
                    "Bracing",
                    "Chilly",
                    "Cool",
                    "Mild",
                    "Warm",
                    "Balmy",
                    "Hot",
                    "Sweltering",
                    "Scorching"
                };

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

                weeklyForecast.Add(forecast);
            };

            return weeklyForecast;
        }

        #region Other Demo Code
        private static void InitializeObzervers()
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
        #endregion
    }
}
