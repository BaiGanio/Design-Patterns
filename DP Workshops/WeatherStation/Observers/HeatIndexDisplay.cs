using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.Observers
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private IObservable _weatherData;

        public HeatIndexDisplay(IObservable weatherData)
        {
            this._weatherData = weatherData;
            this._weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            Display();
        }
        public void Display()
        {
            string heatIndex = string.Format("{0:0.0#}", ComputeHeatIndex(this._temperature, this._humidity));
            Console.WriteLine($"Heat index: {heatIndex} \u2103");
        }

        private double ComputeHeatIndex(double? temp, double? rh)
        {
            double temperature = temp ?? 0;
            double relativeHumidity = rh ?? 0;
            double index =
            (
                16.923 + (0.185212 * temperature) + (5.37941 * relativeHumidity)
                - (0.100254 * temperature * relativeHumidity)
                + (0.00941695 * (temperature * temperature))
                + (0.00728898 * (relativeHumidity * relativeHumidity))
                + (0.000345372 * (temperature * temperature * relativeHumidity))
                - (0.000814971 * (temperature * relativeHumidity * relativeHumidity))
                + (0.0000102102 * (temperature * temperature * relativeHumidity * relativeHumidity))
                - (0.000038646 * (temperature * temperature * temperature))
                + (0.0000291583 * (relativeHumidity * relativeHumidity * relativeHumidity))
                + (0.00000142721 * (temperature * temperature * temperature * relativeHumidity))
                + (0.000000197483 * (temperature * relativeHumidity * relativeHumidity * relativeHumidity))
                - (0.0000000218429 * (temperature * temperature * temperature * relativeHumidity * relativeHumidity))
                + 0.000000000843296 * (temperature * temperature * relativeHumidity * relativeHumidity * relativeHumidity))
                - (0.0000000000481975 * (temperature * temperature * temperature * relativeHumidity * relativeHumidity * relativeHumidity)
            );
            return index;
        }
    }
}
