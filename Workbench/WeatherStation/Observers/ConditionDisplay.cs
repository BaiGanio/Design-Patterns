using System;

namespace WeatherStation
{
    public class ConditionDisplay
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
            Console.WriteLine($"Current conditions: {this._temperature}\u2103 degrees and {this._humidity}% humidity.");
        }
    }
}