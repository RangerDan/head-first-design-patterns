using MiniDuckSimulator.Behaviors;

namespace MiniDuckSimulator.Ducks;

public class Decoy : Duck
{
    public Decoy()
    {
        Console.WriteLine("A decoy has been added to the simulation");
        _flyBehavior = new FlyNoWay();
        _quackBehavior = new QuackMute();
    }

    public override void Display()
    {
        Console.WriteLine("A perfect reproduction of a mallard, except it's not a mallard. It floats serenely");
    }
}