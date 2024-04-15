using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class TelevisionOffCommand : ICommand
{
    private Television _tv;

    public TelevisionOffCommand(Television tv) {
        _tv = tv;
    }

    public void Execute()
    {
        _tv.Off();
    }

    public void Undo()
    {
        _tv.On();
    }
}