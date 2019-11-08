using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.Observers
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private double _temperature = 0;
        private double _humidity = 0;
        private double _pressure;
        private IObservable _weatherData;

        public HeatIndexDisplay(IObservable weatherData)
        {
            _weatherData = weatherData;
            _weatherData.AddObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
        public void Display()
        {
            string heatIndex = $"{ComputeHeatIndex():0.0#}";
            Console.WriteLine($"Heat index: {heatIndex} \u2103");
        }

        private double ComputeHeatIndex()
        {
            double t = _temperature;
            double rh = _humidity;
            double heatIndex =
            (
                16.923 
                + (0.185212 * t)
                + (5.37941 * rh)
                - (0.100254 * t * rh)
                + (0.00941695 * (t * t))
                + (0.00728898 * (rh * rh))
                + (0.000345372 * (t * t * rh))
                - (0.000814971 * (t * rh * rh))
                + (0.0000102102 * (t * t * rh * rh))
                - (0.000038646 * (t * t * t))
                + (0.0000291583 * (rh * rh * rh))
                + (0.00000142721 * (t * t * t * rh))
                + (0.000000197483 * (t * rh * rh * rh))
                - (0.0000000218429 * (t * t * t * rh * rh))
                + 0.000000000843296 * (t * t * rh * rh * rh))
                - (0.0000000000481975 * (t * t * t * rh * rh * rh)
            );
            return heatIndex;
        }
    }
}
