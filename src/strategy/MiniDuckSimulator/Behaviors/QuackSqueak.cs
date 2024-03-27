using MiniDuckSimulator.Interfaces;

namespace MiniDuckSimulator.Behaviors
{
    public class QuackSqueak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak! Squeak! Squeeeeeeaaaak!");
        }
    }
}