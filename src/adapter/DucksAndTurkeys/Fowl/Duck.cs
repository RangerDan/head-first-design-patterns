namespace DucksAndTurkeys.Fowl;

public class Duck : IDuck
{
    public string Name { get; }

    public Duck(string name) {
        Name = name;
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} the duck flies a fair distance");
    }

    public void Quack()
    {
        Console.WriteLine($"{Name} the duck unleashes a mighty quack!");
    }
}