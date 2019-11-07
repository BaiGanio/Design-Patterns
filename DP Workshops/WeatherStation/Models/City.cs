using System.Collections.Generic;

namespace WeatherStation.Models
{
    public class City
    {
        public string Name { get; set; }
        public List<WeatherForecast> WeeklyForecast { get; set; }
        public List<WeatherForecast> ThreeWeeksForecast { get; set; }
    }
}
