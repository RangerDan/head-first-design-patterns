using MiniDuckSimulator.Interfaces;

namespace MiniDuckSimulator.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I believe I can fly, whoooooooo!");
        }
    }
}