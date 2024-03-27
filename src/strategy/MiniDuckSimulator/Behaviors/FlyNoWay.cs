using MiniDuckSimulator.Interfaces;

namespace MiniDuckSimulator.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("If a wingless bird flaps its wings, does it make a sound? NO!");
        }
    }
}