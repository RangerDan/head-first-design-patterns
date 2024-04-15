namespace RemoteControl.Gadgets;

public class GarageDoor {
    public enum Position { CLOSED, PARTIALLY_OPEN, OPEN };
    public Position DoorPosition { get; private set; } = Position.CLOSED;
    public Light? GarageLight { get; set; }

    public GarageDoor() {}

    public void Up() {
        DoorPosition = Position.OPEN;
        Console.WriteLine(ToString());
    }

    public void Down() {
        DoorPosition = Position.CLOSED;
        Console.WriteLine(ToString());
    }

    public void Stop() {
        DoorPosition = Position.PARTIALLY_OPEN;
        Console.WriteLine(ToString());
    }

    private string DoorState() {
        if (DoorPosition == Position.CLOSED) return "Closed";
        if (DoorPosition == Position.PARTIALLY_OPEN) return "Partially Open";
        return "Open";
    }

    public override string ToString() {
        return $"Garage Door is {DoorState()}\n" + GarageLight?.ToString();
    }
}