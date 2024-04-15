using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class HotTubHeaterOnCommand : ICommand
{
    private HotTub _hottub { get; }

    public HotTubHeaterOnCommand(HotTub hottub) {
        _hottub = hottub;
    }

    public void Execute()
    {
        _hottub.HeaterOn();
    }

    public void Undo()
    {
        _hottub.HeaterOff();
    }
}