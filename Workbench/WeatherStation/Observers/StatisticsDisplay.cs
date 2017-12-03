using System;

namespace WeatherStation
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private IObservable _weatherData;

        public StatisticsDisplay(IObservable weatherData)
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
            string temp = string.Format("{0:0.0#}", this._temperature);
            string tempLow = string.Format("{0:0.0#}", this._temperature - 10);
            string tempHigh = string.Format("{0:0.0#}", this._temperature + 10);
            Console.WriteLine($"Statistic: Avg/Min/Max temperature: {temp}/{tempHigh}/{tempLow}");
        }
    }
}
