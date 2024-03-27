using WeatherStation.Observers;

namespace WeatherStation.Subjects;

/// <summary>
/// Interface for being a Subject for Weather data
/// </summary>
public interface IWeatherSubject
{
        void RegisterDisplay(IWeatherDisplay display);

        void RemoveDisplay(IWeatherDisplay display);

        void NotifyAllDisplays();

        double GetTemperature();

        double GetHumidity();

        double GetPressure();
}