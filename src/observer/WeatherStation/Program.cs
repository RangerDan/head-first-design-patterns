using WeatherStation.Observers;
using WeatherStation.Subjects;

namespace WeatherStation;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Weather Station!");
        var data = new WeatherData(90.0, 40.0, 18.0);

        // Current Conditions Display
        var currentConditionsDisplay = new CurrentConditionsDisplay(data);

        // Statistics Display
        var statisticsDisplay = new StatisticsDisplay(data);

        // Forecast Display
        var forecastDisplay = new ForecastDisplay(data);

        data._temperature = 75.0;
        data._humidity = 35.0;
        data._pressure = 35;
        data.NotifyAllDisplays();

        // Drop Displays
        data.RemoveDisplay(currentConditionsDisplay);
        data.NotifyAllDisplays();
    }
}
