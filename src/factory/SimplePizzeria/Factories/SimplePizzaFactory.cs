using SimplePizzeria.Pizzas;

namespace SimplePizzeria.Factories;

public class SimplePizzaFactory {
    public Pizza CreatePizza(string type) {
        if (type == "pepperoni") {
            return new PepperoniPizza();
        } else if (type == "clam") {
            return new ClamPizza();
        } else if (type == "veggie") {
            return new VeggiePizza();
        }
        
        return new CheesePizza();
    }
}