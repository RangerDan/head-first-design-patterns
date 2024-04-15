using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class StereoOffCommand : ICommand
{
    private Stereo _stereo { get; }

    public StereoOffCommand(Stereo stereo) {
        _stereo = stereo;
    }

    public void Execute()
    {
        _stereo.Off();
    }

    public void Undo()
    {
        _stereo.On();
    }
}