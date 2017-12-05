using System;

namespace WeatherStation
{
    public class ConditionDisplay : IObserver,  IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private IObservable _weatherData;

        public ConditionDisplay(IObservable weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            Display();
        }

        public void Display()
        {
            string temp = string.Format("{0:0.0#}", this._temperature);
            string hum = string.Format("{0:0.0#}", this._humidity);
            Console.WriteLine($"Current conditions: {temp}\u2103 degrees and {hum}% humidity.");
        }
    }
}