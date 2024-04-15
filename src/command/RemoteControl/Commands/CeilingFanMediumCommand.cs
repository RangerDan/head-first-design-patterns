using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class CeilingFanMediumCommand : ICommand
{
    private readonly CeilingFan _fan;
    private CeilingFan.FanSpeed previousSpeed;

    public CeilingFanMediumCommand(CeilingFan fan) {
        _fan = fan;
    }

    public void Execute()
    {
        previousSpeed = _fan.Speed;
        _fan.Medium();
    }

    public void Undo()
    {
        if (previousSpeed == CeilingFan.FanSpeed.OFF) {
            _fan.Off();
        } else if (previousSpeed == CeilingFan.FanSpeed.LOW) {
            _fan.Low();
        } else if (previousSpeed == CeilingFan.FanSpeed.MEDIUM) {
            _fan.Medium();
        } else {
            _fan.High();
        }
    }
}