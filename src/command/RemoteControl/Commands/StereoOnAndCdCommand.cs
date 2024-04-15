using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class StereoOnAndCdCommand : ICommand
{
    private Stereo _stereo { get; }

    public StereoOnAndCdCommand(Stereo stereo) {
        this._stereo = stereo;
    }

    public void Execute()
    {
        _stereo.On();
        _stereo.SetCd();
    }

    public void Undo()
    {
        _stereo.Off();
    }
}