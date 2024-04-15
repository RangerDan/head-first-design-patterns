using RemoteControl.Commands;

namespace RemoteControl.Remotes;

public class SimpleRemoteControl {
    public ICommand? Slot { get; set; }

    public SimpleRemoteControl() {}

    public void SetCommand(ICommand command) {
        Slot = command;
    }

    public void ButtonWasPressed() {
        Slot?.Execute();
    }
}