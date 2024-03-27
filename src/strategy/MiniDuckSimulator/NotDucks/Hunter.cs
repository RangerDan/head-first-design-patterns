using MiniDuckSimulator.Interfaces;
using MiniDuckSimulator.Behaviors;

namespace MiniDuckSimulator.NotDucks;
public class Hunter
{
    IQuackBehavior _quackBehavior { get; set; }

    public Hunter() {
        Console.WriteLine("A Hunter has approached the pond...");
        _quackBehavior = new QuackDuckCall();
    }

    public void Display() {
        Console.WriteLine("I'm wearing camoflage. You can't see me!");
    }

    // public void PerformFly() { // Hunters can't fly! }

    public void PerformQuack()
    {
        if (_quackBehavior != null)
        {
            _quackBehavior.Quack();
        }
    }
}