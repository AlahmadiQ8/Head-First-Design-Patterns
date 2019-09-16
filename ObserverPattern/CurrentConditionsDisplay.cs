using System;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay: IDisplayElement, IObserver<WeatherInfo>
    {
        private readonly IObservable<WeatherInfo> _weatherData;
        private WeatherInfo _weatherInfo;
        private readonly IDisposable _cancellation;

        public CurrentConditionsDisplay(IObservable<WeatherInfo> weatherData)
        {
            _weatherData = weatherData;
            _cancellation = _weatherData.Subscribe(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_weatherInfo.Temp} F degrees and {_weatherInfo.Humidity} % humidity");
        }

        public void Unsubscribe()
        {
            _cancellation.Dispose();
            _weatherInfo = null;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherInfo info)
        {
            _weatherInfo = new WeatherInfo(info.Temp, info.Humidity, info.Pressure);
            Display();
        }
    }
}