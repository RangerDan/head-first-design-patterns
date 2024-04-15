using RemoteControl.Gadgets;

namespace RemoteControl.Commands;

public class NoCommand : ICommand
{
    public NoCommand() {}

    public void Execute()
    {
        Console.WriteLine("Empty Command Executed");
    }

    public void Undo()
    {
        Console.WriteLine("Empty Command Undone");
    }
}