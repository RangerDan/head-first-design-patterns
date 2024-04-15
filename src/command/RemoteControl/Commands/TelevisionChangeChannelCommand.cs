using System.Runtime.CompilerServices;
using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class TelevisionChangeChannelCommand : ICommand
{
    private int _previousChannel;
    private Television _tv;
    private int _channel;

    public TelevisionChangeChannelCommand(Television tv, int channel) {
        _tv = tv;
        _channel = channel;
    }

    public void Execute()
    {
        _previousChannel = _tv.Channel;
        _tv.ChangeChannel(_channel);
    }

    public void Undo()
    {
        _tv.ChangeChannel(_previousChannel);
    }
}