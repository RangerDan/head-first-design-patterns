using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class GarageDoorDownCommand : ICommand
{
    private readonly GarageDoor _door;

    public GarageDoorDownCommand(GarageDoor door) {
        _door = door;
    }

    public void Execute()
    {
        _door.Down();
    }

    public void Undo()
    {
        _door.Up();
    }
}