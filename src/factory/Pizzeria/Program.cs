using Utilities;
using Pizzeria.Stores;

class Program
{
    static void Main(string[] args)
    {
        PizzaStore nyStore = new NYPizzaStore();

        ConsoleUtilities.Separator();
        nyStore.OrderPizza("cheese");
        ConsoleUtilities.Separator();
        nyStore.OrderPizza("veggie");
        ConsoleUtilities.Separator();
        
        PizzaStore chicagoStore = new ChicagoPizzaStore();
        chicagoStore.OrderPizza("cheese");
        ConsoleUtilities.Separator();
        chicagoStore.OrderPizza("clam");
        
        PizzaStore californiaStore = new CaliforniaPizzaStore();
        ConsoleUtilities.Separator();
        californiaStore.OrderPizza("veggie");
        ConsoleUtilities.Separator();
    }
}