using MiniDuckSimulator.Behaviors;
using MiniDuckSimulator.Ducks;
using MiniDuckSimulator.NotDucks;

namespace MiniDuckSimulator;
class Program
{
    static void Main(string[] args)
    {
        var myDuck = new MallardDuck();

        myDuck.Display();
        myDuck.Swim();
        myDuck.PerformFly();
        myDuck.PerformQuack();

        var newDuck = new Decoy();
        newDuck.Display();
        newDuck.PerformFly();
        newDuck.PerformQuack();
        newDuck._flyBehavior = new FlyWithRockets();
        newDuck.PerformFly();

        var hunter = new Hunter();
        hunter.Display();
        hunter.PerformQuack();
    }
}
