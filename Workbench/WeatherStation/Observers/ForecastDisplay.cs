using System;

namespace WeatherStation
{
    public class ForecastDisplay
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public void Update(double temp, double humidity, double pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Forecast: Still improving the calculations.....");
        }
    }
}
