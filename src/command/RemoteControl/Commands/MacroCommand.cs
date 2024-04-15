namespace RemoteControl.Commands;

public class MacroCommand : ICommand
{
    private readonly IList<ICommand> Commands;

    public MacroCommand(IList<ICommand> commands) {
        Commands = commands;
    }

    public void Execute()
    {
        foreach(var command in Commands) {
            command.Execute();
        }        
    }

    public void Undo()
    {
        foreach(var undoCommand in Commands.Reverse()) {
            undoCommand.Undo();
        }
    }
}