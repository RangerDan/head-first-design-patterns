using Pizzeria.Pizzas;

namespace Pizzeria.Stores;

public class ChicagoPizzaStore : PizzaStore {
    public override Pizza CreatePizza(string type)
    {
        if (type == "pepperoni") {
            return new ChicagoStylePepperoniPizza();
        } else if (type == "clam") {
            return new ChicagoStyleClamPizza();
        } else if (type == "veggie") {
            return new ChicagoStyleVeggiePizza();
        }
        
        return new ChicagoStyleCheesePizza();
    }
}