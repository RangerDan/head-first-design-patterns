using WeatherStation.Subjects;

namespace WeatherStation.Observers
{
    public class ForecastDisplay : IWeatherDisplay, IDisplayElement
    {
        private double _currentTemperature;
        private double _previousTemperature;
        private double _currentHumidity;
        private double _previousHumidity;
        private double _currentPressure;
        private double _previousPressure;
        private IWeatherSubject _subject;

        public ForecastDisplay(IWeatherSubject subject)
        {
            _subject = subject;
            _subject.RegisterDisplay(this);
            _currentTemperature = _previousTemperature = _subject.GetTemperature();
            _currentHumidity = _previousHumidity = _subject.GetHumidity();
            _currentPressure = _previousPressure = _subject.GetPressure();
        }

        public void Display()
        {
            Console.WriteLine("---Forecast---");
            Console.WriteLine(_currentPressure > _previousPressure ? "Conditions Improving" : "Conditions Worsening");
        }

        public void Update()
        {
            _previousTemperature = _currentTemperature;
            _currentTemperature = _subject.GetTemperature();
            _previousHumidity = _currentHumidity;
            _currentHumidity = _subject.GetHumidity();
            _previousPressure = _currentPressure;
            _currentPressure = _subject.GetPressure();

            Display();
        }
    }
}