namespace DucksAndTurkeys.Fowl;

public class Turkey : ITurkey
{
    public string Name { get; }

    public Turkey(string name) {
        Name = name;
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} the turkey flies a little");
    }

    public void Gobble()
    {
        Console.WriteLine($"{Name} the turkey gobbles in the night");
    }
    
    public void FanTail()
    {
        Console.WriteLine($"{Name} the turkey fans its tail in a display of dominance");
    }
}