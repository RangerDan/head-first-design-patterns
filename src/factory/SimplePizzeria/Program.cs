using Utilities;
using SimplePizzeria.Factories;
using SimplePizzeria.Stores;

class Program
{
    static void Main(string[] args)
    {
        SimplePizzaFactory factory = new SimplePizzaFactory();
        PizzaStore store = new PizzaStore(factory);

        ConsoleUtilities.Separator();
        store.OrderPizza("cheese");
        ConsoleUtilities.Separator();
        store.OrderPizza("veggie");
        ConsoleUtilities.Separator();
    }
}