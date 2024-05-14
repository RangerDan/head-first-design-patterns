namespace DucksAndTurkeys.Fowl;

public class TurkeyAdapter : ITurkey
{
    IDuck Duck { get; }

    public TurkeyAdapter(IDuck duck) {
        Duck = duck;
    }

    public void Fly()
    {
        Console.WriteLine("The duck shows off:");
        Duck.Fly();
    }

    public void Gobble()
    {
        Console.WriteLine("The duck tries to gobble");
        Duck.Quack();
    }

    public void FanTail()
    {
        throw new NotImplementedException("Ducks can't fan their tails like turkeys can!");
    }
}