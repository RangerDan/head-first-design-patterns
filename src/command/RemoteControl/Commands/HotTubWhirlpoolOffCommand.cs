using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class HotTubWhirlpoolOffCommand : ICommand
{
    private HotTub _hottub { get; }

    public HotTubWhirlpoolOffCommand(HotTub hottub) {
        _hottub = hottub;
    }

    public void Execute()
    {
        _hottub.WhirlpoolOff();
    }

    public void Undo()
    {
        _hottub.WhirlpoolOn();
    }
}