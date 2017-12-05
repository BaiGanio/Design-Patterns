using System;

namespace WeatherStation
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private IObservable _weatherData;

        public ForecastDisplay(IObservable weatherData)
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
            Console.WriteLine($"Forecast: More of the same. Still improving the calculations.....");
        }
    }
}
