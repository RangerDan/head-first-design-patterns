using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class GarageDoorUpCommand : ICommand
{
    private readonly GarageDoor _door;

    public GarageDoorUpCommand(GarageDoor door) {
        _door = door;
    }

    public void Execute()
    {
        _door.Up();
    }

    public void Undo()
    {
        _door.Down();
    }
}