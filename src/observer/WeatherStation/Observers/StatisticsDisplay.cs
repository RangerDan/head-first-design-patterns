using WeatherStation.Subjects;

namespace WeatherStation.Observers
{
    public class StatisticsDisplay : IWeatherDisplay, IDisplayElement
    {
        private List<double> _temperatures;
        private List<double> _humidities;
        private List<double> _pressures;
        private IWeatherSubject _subject;

        public StatisticsDisplay(IWeatherSubject subject)
        {
            _subject = subject;
            _temperatures = new List<double>() { subject.GetTemperature() };
            _humidities = new List<double>() { subject.GetHumidity() };
            _pressures = new List<double>() { _subject.GetPressure() };
            _subject.RegisterDisplay(this);
        }

        public void Display()
        {
            Console.WriteLine($"---Statistics---");
            Console.WriteLine(_temperatures.Count > 0 ? $"Avg Temperature: {_temperatures.Average()}" : "Avg Temperature Data Not Available");
            Console.WriteLine(_humidities.Count > 0 ? $"Avg Humidity: {_humidities.Average()}" : "Avg Humidity Data Not Available");
            Console.WriteLine(_pressures.Count > 0 ? $"Avg Pressure: {_pressures.Average()}" : "Avg Pressure Data Not Available");
        }

        public void Update()
        {
            if (_subject.GetTemperature() > 1)
            {
                _temperatures.Add(_subject.GetTemperature());
                if (_temperatures.Count > 5)
                {
                    _temperatures.RemoveRange(0, _temperatures.Count - 5);
                }
            }

            if (_subject.GetHumidity() > 1)
            {
                _humidities.Add(_subject.GetHumidity());
                if (_humidities.Count > 5)
                {
                    _humidities.RemoveRange(0, _humidities.Count - 5);
                }
            }

            if (_subject.GetPressure() > 1)
            {
                _pressures.Add(_subject.GetPressure());
                if (_pressures.Count > 5)
                {
                    _pressures.RemoveRange(0, _pressures.Count - 5);
                }
            }

            Display();
        }
    }
}