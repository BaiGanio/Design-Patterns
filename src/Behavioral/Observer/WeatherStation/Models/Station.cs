using System.Collections.Generic;

namespace WeatherStation
{
    public class Station
    {
        public string Name { get; set; }
        public List<WeatherForecast> OneWeekForecast { get; set; }
        public List<WeatherForecast> ThreeWeeksForecast { get; set; }
    }
}
