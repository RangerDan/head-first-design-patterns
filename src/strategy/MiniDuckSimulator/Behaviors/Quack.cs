using MiniDuckSimulator.Interfaces;

namespace MiniDuckSimulator.Behaviors
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack. You know, like an actual duck.");
        }
    }
}