using WeatherStation.Subjects;

namespace WeatherStation.Observers
{
    public class CurrentConditionsDisplay : IWeatherDisplay, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private IWeatherSubject _subject;

        public CurrentConditionsDisplay(IWeatherSubject subject)
        {
            _subject = subject;
            _temperature = _subject.GetTemperature();
            _humidity = _subject.GetHumidity();
            _subject.RegisterDisplay(this);
        }

        public void Display()
        {
            Console.WriteLine($"---Current Conditions---");
            Console.WriteLine($"Temperature: {_temperature}");
            Console.WriteLine($"Humidity: {_humidity}");
        }

        public void Update()
        {
            _temperature = _subject.GetTemperature();
            _humidity = _subject.GetHumidity();

            Display();
        }
    }
}