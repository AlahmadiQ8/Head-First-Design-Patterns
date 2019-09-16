namespace ObserverPattern
{
    public class WeatherInfo
    {
        public WeatherInfo(float temp, float humidity, float pressure)
        {
            Temp = temp;
            Humidity = humidity;
            Pressure = pressure;
        }

        public float Temp { get; }
        public float Humidity { get; }
        public float Pressure { get; }
    }
}