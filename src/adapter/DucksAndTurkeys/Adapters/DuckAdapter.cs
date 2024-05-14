namespace DucksAndTurkeys.Fowl;

public class DuckAdapter : IDuck
{
    ITurkey Turk { get; }

    public DuckAdapter(ITurkey turk) {
        Turk = turk;
    }

    public void Fly()
    {
        Console.WriteLine("The turkey tries its best to be a duck:");
        Turk.Fly();
        Turk.Fly();
        Turk.Fly();
        Turk.Fly();
        Turk.Fly();
    }

    public void Quack()
    {
        Console.WriteLine("The turkey can't quack, but it tries...");
        Turk.Gobble();
    }
}