namespace RemoteControl.Gadgets;

public class Light {
    public bool OnState { get; private set; } = false;

    public void On() {
        OnState = true;
        Console.WriteLine(ToString());
    }

    public void Off() {
        OnState = false;
        Console.WriteLine(ToString());
    }

    public void Toggle() {
        OnState = !OnState;
        Console.WriteLine(ToString());
    }

    public override string ToString() {
        return $"Light is {(OnState ? "On" : "Off")}";
    }
}