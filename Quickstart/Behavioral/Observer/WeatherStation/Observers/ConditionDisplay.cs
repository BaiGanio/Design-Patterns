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
            _weatherData = weatherData;
            weatherData.AddObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            string temp = string.Format("{0:0.0#}", _temperature);
            string hum = string.Format("{0:0.0#}", _humidity);
            Console.WriteLine($"Current conditions: {temp}{(char)176}C degrees and {hum}% humidity.");
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}