using System;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);

            currentConditionsDisplay.Unsubscribe();

            weatherData.SetMeasurements(80, 65, 30.4f);
        }
    }
}
