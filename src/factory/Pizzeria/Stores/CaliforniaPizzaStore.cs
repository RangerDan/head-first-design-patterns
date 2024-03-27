using Pizzeria.Pizzas;

namespace Pizzeria.Stores;

public class CaliforniaPizzaStore : PizzaStore {
    public override Pizza CreatePizza(string type)
    {
        if (type == "pepperoni") {
            return new CaliforniaStylePepperoniPizza();
        } else if (type == "clam") {
            return new CaliforniaStyleClamPizza();
        } else if (type == "veggie") {
            return new CaliforniaStyleVeggiePizza();
        }
        
        return new CaliforniaStyleCheesePizza();
    }
}