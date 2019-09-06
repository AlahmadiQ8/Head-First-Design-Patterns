using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : ISubject<WeatherInfo>
    {
        private readonly WeatherInfo _weatherInfo;
        private readonly List<IObserver<WeatherInfo>> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver<WeatherInfo>>();
            _weatherInfo = new WeatherInfo();
        }

        public void RegisterObserver(IObserver<WeatherInfo> o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver<WeatherInfo> o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_weatherInfo);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _weatherInfo.Temp = temp;
            _weatherInfo.Humidity = humidity;
            _weatherInfo.Pressure = pressure;
        }
    }
}