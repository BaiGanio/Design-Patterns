namespace WeatherStation
{
    public class WeatherData
    {
        private CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay();

        public void MeasurementsChanged()
        {
            double temp = GetTemperature();
            double humidity = GetHumidity();
            double pressure = GetPressure();

            this.currentConditionDisplay.Update(temp, humidity, pressure);
        }

        private double GetPressure()
        {
            return 86.12;
        }

        private double GetHumidity()
        {
            return 56.77;
        }

        private double GetTemperature()
        {
            return 18.7;
        }
    }
}
