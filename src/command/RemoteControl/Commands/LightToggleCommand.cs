using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class LightToggleCommand : ICommand
{
    private Light _light;

    public LightToggleCommand(Light light) {
        _light = light;
    }

    public void Execute()
    {
        _light.Toggle();
    }

    public void Undo()
    {
        _light.Toggle();
    }
}