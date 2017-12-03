using System;

namespace WeatherStation.Observers
{
    public class ThirdPartydisplay : IDisplayElement
    {
        public void Display()
        {
            Console.WriteLine("Display something else based on measurements.");
        }
    }
}
