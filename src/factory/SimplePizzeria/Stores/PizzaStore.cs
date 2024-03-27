using SimplePizzeria.Factories;
using SimplePizzeria.Pizzas;

namespace SimplePizzeria.Stores;

public class PizzaStore {
    private SimplePizzaFactory Factory;

    public PizzaStore(SimplePizzaFactory factory) {
        Factory = factory;
    }

    public Pizza OrderPizza(string type) {
        Pizza Pie = Factory.CreatePizza(type);

        Pie.Prepare();
        Pie.Bake();
        Pie.Cut();
        Pie.Box();

        return Pie;
    }
}