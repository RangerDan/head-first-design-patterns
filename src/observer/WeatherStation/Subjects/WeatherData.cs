using WeatherStation.Observers;

namespace WeatherStation.Subjects;

public class WeatherData : IWeatherSubject
{
    private List<IWeatherDisplay> displays;
    public double _temperature { get; set; }
    public double _humidity { get; set; }
    public double _pressure { get; set; }

    public WeatherData(double temp, double humi, double pres)
    {
        _temperature = temp;
        _humidity = humi;
        _pressure = pres;
        displays = new List<IWeatherDisplay>();
    }

    public void RegisterDisplay(IWeatherDisplay display)
    {
        Console.WriteLine($"Registering Display: {display.ToString()}");
        displays.Add(display);
        display.Update();
    }

    public void RemoveDisplay(IWeatherDisplay display)
    {
        Console.WriteLine($"Removing Display: {display.ToString()}");
        displays.Remove(display);
    }

    public void NotifyAllDisplays()
    {
        Console.WriteLine($"Notifying all Displays of current conditions.");
        foreach (var display in displays) {
            display.Update();
        }
    }

    public double GetTemperature()
    {
        return _temperature;
    }

    public double GetHumidity()
    {
        return _humidity;
    }

    public double GetPressure()
    {
        return _pressure;
    }
}