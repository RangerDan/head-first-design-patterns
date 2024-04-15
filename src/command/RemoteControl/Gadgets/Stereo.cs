using System.Text;

namespace RemoteControl.Gadgets;

public class Stereo {
    public enum Modes { CD, DVD, RADIO };
    public Modes Mode { get; private set; } = Modes.RADIO;
    public bool PowerOnState { get; private set; } = false;
    public int Volume { get; private set; } = 5;

    public void On() {
        PowerOnState = true;
    }

    public void Off() {
        PowerOnState = false;
        Console.WriteLine(ToString());
    }

    public void SetCd() {
        Mode = Modes.CD;
        Console.WriteLine(ToString());
    }

    public void SetDvd() {
        Mode = Modes.DVD;
        Console.WriteLine(ToString());
    }

    public void SetRadio() {
        Mode = Modes.RADIO;
        Console.WriteLine(ToString());
    }

    public void SetVolumeUp() {
        if (Volume < 12) {
            Volume++;
        }
        Console.WriteLine(ToString());
    }

    public void SetVolumeDown() {
        if (Volume > 0) {
            Volume--;
        }
        Console.WriteLine(ToString());
    }

    private string ModeToString() =>
        Mode == Modes.CD ? "CD Mode"
        : Mode == Modes.DVD ? "DVD Mode"
        : "Radio Mode";

    public override string ToString() {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Modern Stereo Receiver");
        stringBuilder.AppendLine(ModeToString());
        stringBuilder.AppendLine($"Volume: {Volume}");
        stringBuilder.AppendLine($"Power: {(PowerOnState ? "ON" : "OFF")}");
        return stringBuilder.ToString();
    }
}