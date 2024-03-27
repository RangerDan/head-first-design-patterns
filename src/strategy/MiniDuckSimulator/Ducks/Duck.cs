using MiniDuckSimulator.Interfaces;

namespace MiniDuckSimulator.Ducks;
public abstract class Duck
{
    public IFlyBehavior? _flyBehavior { get; set; }
    public IQuackBehavior? _quackBehavior { get; set; }

    protected Duck()
    {

    }

    public abstract void Display();

    public void PerformFly()
    {
        if (_flyBehavior != null)
        {
            _flyBehavior.Fly();
        }
    }

    public void PerformQuack()
    {
        if (_quackBehavior != null)
        {
            _quackBehavior.Quack();
        }
    }

    public void Swim()
    {
        Console.WriteLine("We all float down here.");
    }
}