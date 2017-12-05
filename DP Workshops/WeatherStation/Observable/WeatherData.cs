using System.Collections.Generic;

namespace WeatherStation
{
    public class WeatherData : IObservable
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private List<IObserver> observers;

        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int i = this.observers.IndexOf(observer);
            if (i >= 0)
            {
                this.observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in this.observers)
            {
                observer.Update(this._temperature, this._humidity, this._pressure);
            }
        }
    }
}
