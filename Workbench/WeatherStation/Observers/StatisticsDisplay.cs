using System;

namespace WeatherStation
{
    public class StatisticsDisplay
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
            Console.WriteLine($"Statistic: Avg/Min/Max temperature: {this._temperature}/{this._temperature}/{this._temperature}");
        }
    }
}
