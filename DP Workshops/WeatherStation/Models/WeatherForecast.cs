using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherForecast
    {
        public DateTime Date { get; internal set; }
        public string Summary { get; internal set; }
        public double TemperatureC { get; internal set; }
        public double Humidity { get; internal set; }
        public double Pressure { get; internal set; }
    }
}
