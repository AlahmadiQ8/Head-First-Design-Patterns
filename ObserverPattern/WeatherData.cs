using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : IObservable<WeatherInfo>
    {
        private WeatherInfo _weatherInfo;
        private readonly List<IObserver<WeatherInfo>> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver<WeatherInfo>>();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _weatherInfo = new WeatherInfo(temp, humidity, pressure);
            foreach (var observer in _observers)
            {
                observer.OnNext(_weatherInfo);
            }
        }

        public IDisposable Subscribe(System.IObserver<WeatherInfo> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscriber<WeatherInfo>(_observers, observer);
        }
    }
}