using MiniDuckSimulator.Interfaces;

namespace MiniDuckSimulator.Behaviors
{
    public class QuackMute : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("-- Silence is Golden --");
        }
    }
}