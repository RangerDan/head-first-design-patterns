
namespace RemoteControl.Gadgets;

public class HotTub {
    public bool IsHeaterOn { get; protected set; }
    public bool IsWhirlpoolOn { get; protected set; }

    public HotTub() {
        IsHeaterOn = false;
        IsWhirlpoolOn = false;
    }

    public void HeaterOn() {
        IsHeaterOn = true;
        Console.WriteLine(ToString());
    }

    public void HeaterOff() {
        IsHeaterOn = false;
        Console.WriteLine(ToString());
    }

    public void WhirlpoolOn() {
        IsWhirlpoolOn = true;
        Console.WriteLine(ToString());
    }

    public void WhirlpoolOff() {
        IsWhirlpoolOn = false;
        Console.WriteLine(ToString());
    }

    public override string ToString() {
        return $"The Hot Tub is {(IsHeaterOn ? $"Hot" : "Cold")} and the Whirlpool is {(IsWhirlpoolOn ? "On" : "Off")}";
    }
}