using System;
using System.Collections.Generic;

namespace WeatherStation
{
    public class WeatherData : IObservable
    {
        private DateTime? _date;
        private string _summary;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        private List<IObserver> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure, string summary = null, DateTime? date = null)
        {
            _date = date ?? DateTime.MinValue;
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            _summary = summary ?? "N/A";
            OnMeasurementsChanged();
        }

        private void OnMeasurementsChanged()
        {
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        internal void SetMeasurements(WeatherForecast forecast)
        {
            _date = forecast.Date;
            _temperature = forecast.TemperatureC;
            _humidity = forecast.Humidity;
            _pressure = forecast.Pressure;
            _summary = forecast.Summary;
            OnMeasurementsChanged();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int i = _observers.IndexOf(observer);
            if (i >= 0)
            {
                _observers.Remove(observer);
            }
        }
    }
}
