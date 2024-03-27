using Pizzeria.Pizzas;

namespace Pizzeria.Stores;

public abstract class PizzaStore {
    public Pizza OrderPizza(string type) {
        Pizza Pie = CreatePizza(type);

        Pie.Prepare();
        Pie.Bake();
        Pie.Cut();
        Pie.Box();

        return Pie;
    }

    public abstract Pizza CreatePizza(string type);
}