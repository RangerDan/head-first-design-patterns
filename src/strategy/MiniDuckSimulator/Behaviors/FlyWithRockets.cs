using MiniDuckSimulator.Interfaces;

namespace MiniDuckSimulator.Behaviors
{
    public class FlyWithRockets : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Blatherin Blatherskite -- I'm airborne!");
        }
    }
}