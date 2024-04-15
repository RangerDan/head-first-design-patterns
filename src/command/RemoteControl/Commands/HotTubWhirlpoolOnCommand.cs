using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class HotTubWhirlpoolOnCommand : ICommand
{
    private HotTub _hottub { get; }

    public HotTubWhirlpoolOnCommand(HotTub hottub) {
        _hottub = hottub;
    }

    public void Execute()
    {
        _hottub.WhirlpoolOn();
    }

    public void Undo()
    {
        _hottub.WhirlpoolOff();
    }
}