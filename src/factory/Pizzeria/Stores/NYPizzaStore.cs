using Pizzeria.Pizzas;

namespace Pizzeria.Stores;

public class NYPizzaStore : PizzaStore {
    public override Pizza CreatePizza(string type)
    {
        if (type == "pepperoni") {
            return new NYStylePepperoniPizza();
        } else if (type == "clam") {
            return new NYStyleClamPizza();
        } else if (type == "veggie") {
            return new NYStyleVeggiePizza();
        }
        
        return new NYStyleCheesePizza();
    }
}