using Utilities;
using AbstractPizzeria.Stores;
using AbstractPizzeria.Pizzas;

class Program
{
    static void Main(string[] args)
    {
        PizzaStore nyStore = new NYPizzaStore();
        Pizza pizza;

        ConsoleUtilities.Separator();
        pizza = nyStore.OrderPizza("cheese");
        Console.WriteLine("Order Up! " + pizza);
        ConsoleUtilities.Separator();
        pizza = nyStore.OrderPizza("veggie");
        Console.WriteLine("Order Up! " + pizza);
        ConsoleUtilities.Separator();
        
        PizzaStore chicagoStore = new ChicagoPizzaStore();
        pizza = chicagoStore.OrderPizza("cheese");
        Console.WriteLine("Order Up! " + pizza);
        ConsoleUtilities.Separator();
        pizza = chicagoStore.OrderPizza("clam");
        Console.WriteLine("Order Up! " + pizza);
    }
}