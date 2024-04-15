using System.Drawing;
using System.Text;
using RemoteControl.Commands;

namespace RemoteControl.Remotes;

public class FullRemoteControl {
    private const int size = 7;
    public Stack<ICommand> UndoCommands { get; set; }
    public ICommand[] OnCommands { get; set; }
    public ICommand[] OffCommands { get; set; }

    public FullRemoteControl() {
        UndoCommands = new Stack<ICommand>();
        OnCommands = new ICommand[size];
        OffCommands = new ICommand[size];

        for(int index = 0; index < size; index++) {
            OnCommands[index] = new NoCommand();
            OffCommands[index] = new NoCommand();
        }
    }

    public void SetSlotCommand(int slot, ICommand onCommand, ICommand offCommand) {
        OnCommands[slot] = onCommand;
        OffCommands[slot] = offCommand;
    }

    public void OnButtonWasPressed(int slot) {
        UndoCommands.Push(OnCommands[slot]);
        OnCommands[slot].Execute();
    }

    public void OffButtonWasPressed(int slot) {
        UndoCommands.Push(OffCommands[slot]);
        OffCommands[slot].Execute();
    }

    public void UndoButtonWasPressed() {
        if (UndoCommands.Count > 0) {
            UndoCommands.Pop().Undo();
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Remote Control --------- ON ----------------------- OFF ------");
        for(int index = 0; index < OnCommands.Length; index++) {
            stringBuilder.AppendLine($"[slot {index}] {OnCommands[index].GetType().ToString()} - {OffCommands[index].GetType().ToString()}");
        }
        stringBuilder.AppendLine($"[Undo Length] {UndoCommands.Count}");
        return stringBuilder.ToString();
    }
}