
namespace RemoteControl.Gadgets;

public class Television {
    public bool OnState { get; protected set; }
    public string Location { get; protected set; }
    public int Channel { get; protected set; }

    public Television(string loc, int channel) {
        Location = loc;
        Channel = channel;
        OnState = false;
    }

    public void On() {
        OnState = true;
        Console.WriteLine(ToString());
    }

    public void Off() {
        OnState = false;
        Console.WriteLine(ToString());
    }

    public void ChangeChannel(int channel) {
        Channel = channel;
        Console.WriteLine(ToString());
    }

    public override string ToString() {
        return $"The TV in the {Location} is {(OnState ? $"On and set to channel {Channel}" : "Off")}";
    }
}