using System;

namespace WeatherStation
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private IObservable _weatherData;

        public ForecastDisplay() { }
        public ForecastDisplay(IObservable weatherData)
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
            Console.WriteLine($"{"Temp",-20}| {"Humidity",-30}| {"Pressure",-20}|\n");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(
                   $"{_temperature,-20}| " +
                   $"{_humidity,-30:N2}| " +
                   //$"{forecasts[i].TemperatureC,-12:N2}| " +
                   $"{_pressure,-20:N2}|"
               );
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
    }
}
