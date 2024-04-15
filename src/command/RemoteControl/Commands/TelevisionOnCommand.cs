using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class TelevisionOnCommand : ICommand
{
    private Television _tv;

    public TelevisionOnCommand(Television tv) {
        _tv = tv;
    }

    public void Execute()
    {
        _tv.On();
    }

    public void Undo()
    {
        _tv.Off();
    }
}