namespace WeatherStation
{
    public class WeatherData
    {
        private ConditionDisplay currentConditionDisplay = new ConditionDisplay();
        private StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
        private ForecastDisplay forecastDisplay = new ForecastDisplay();

        public void MeasurementsChanged()
        {
            double temp = GetTemperature();
            double humidity = GetHumidity();
            double pressure = GetPressure();

            this.currentConditionDisplay.Update(temp, humidity, pressure);
            this.statisticsDisplay.Update(temp, humidity, pressure);
            this.forecastDisplay.Update(temp, humidity, pressure);
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
