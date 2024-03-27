using MiniDuckSimulator.Behaviors;

namespace MiniDuckSimulator.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        Console.WriteLine("A Mallard has been added to the simulation");
        _flyBehavior = new FlyWithWings();
        _quackBehavior = new Quack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a Mallard!");
    }
}