using System;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay: IDisplayElement, IObserver<WeatherInfo>
    {
        private ISubject<WeatherInfo> _weatherData;
        private WeatherInfo _weatherInfo;

        public CurrentConditionsDisplay(ISubject<WeatherInfo> weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
            _weatherInfo = new WeatherInfo();
        }

        public void Update(WeatherInfo info)
        {
            _weatherInfo.Temp = info.Temp;
            _weatherInfo.Humidity = info.Humidity;
            _weatherInfo.Pressure = info.Pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_weatherInfo.Temp} F degrees and {_weatherInfo.Humidity} % humidity");
        }
    }
}