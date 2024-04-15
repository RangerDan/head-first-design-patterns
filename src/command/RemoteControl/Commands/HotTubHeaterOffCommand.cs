using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class HotTubHeaterOffCommand : ICommand
{
    private HotTub _hottub { get; }

    public HotTubHeaterOffCommand(HotTub hottub) {
        _hottub = hottub;
    }

    public void Execute()
    {
        _hottub.HeaterOff();
    }

    public void Undo()
    {
        _hottub.HeaterOn();
    }
}