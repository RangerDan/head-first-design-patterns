using MiniDuckSimulator.Interfaces;

namespace MiniDuckSimulator.Behaviors
{
    public class QuackDuckCall : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack-ish. And a tiny bit of old-timey aww-shucks racism from Duck Commander.");
        }
    }
}