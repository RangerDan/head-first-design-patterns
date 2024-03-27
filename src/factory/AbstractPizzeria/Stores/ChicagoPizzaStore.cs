using AbstractPizzeria.Pizzas;
using AbstractPizzeria.Factories;

namespace AbstractPizzeria.Stores;

public class ChicagoPizzaStore : PizzaStore {
    public override Pizza CreatePizza(string type)
    {
        Pizza pizza;
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        if (type == "pepperoni") {
            pizza = new PepperoniPizza(ingredientFactory);
            pizza.Name = "Chicago Style Pepperoni Pizza";
        } else if (type == "clam") {
            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "Chicago Style Clam Pizza";
        } else if (type == "veggie") {
            pizza = new VeggiePizza(ingredientFactory);
            pizza.Name = "Chicago Style Veggie Pizza";
        } else {
            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "Chicago Style Cheese Pizza";
        }

        return pizza;
    }
}