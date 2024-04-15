namespace RemoteControl.Gadgets;

public class CeilingFan {
    public enum FanSpeed {OFF, LOW, MEDIUM, HIGH};
    public FanSpeed Speed { get; protected set; }
    public string Location { get; protected set; }

    public CeilingFan(string loc) {
        Location = loc;
        Speed = FanSpeed.OFF;
    }

    public void High() {
        Speed = FanSpeed.HIGH;
        Console.WriteLine(ToString());
    }

    public void Medium() {
        Speed = FanSpeed.MEDIUM;
        Console.WriteLine(ToString());
    }

    public void Low() {
        Speed = FanSpeed.LOW;
        Console.WriteLine(ToString());
    }

    public void Off() {
        Speed = FanSpeed.OFF;
        Console.WriteLine(ToString());
    }

    public static string FanSpeedDescription(FanSpeed speed) {
        return speed == FanSpeed.OFF ? "Off" :
        speed == FanSpeed.LOW ? "Low" :
        speed == FanSpeed.MEDIUM ? "Medium" :
        "High";
    }

    public override string ToString() {
        return $"The ceiling fan in the {Location} is set to speed {FanSpeedDescription(Speed)}";
    }
}