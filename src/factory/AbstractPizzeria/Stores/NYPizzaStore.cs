using AbstractPizzeria.Pizzas;
using AbstractPizzeria.Factories;

namespace AbstractPizzeria.Stores;

public class NYPizzaStore : PizzaStore {
    public override Pizza CreatePizza(string type)
    {
        Pizza pizza;
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        if (type == "pepperoni") {
            pizza = new PepperoniPizza(ingredientFactory);
            pizza.Name = "New York Style Pepperoni Pizza";
        } else if (type == "clam") {
            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "New York Style Clam Pizza";
        } else if (type == "veggie") {
            pizza = new VeggiePizza(ingredientFactory);
            pizza.Name = "New York Style Veggie Pizza";
        } else {
            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "New York Style Cheese Pizza";
        }

        return pizza;
    }
}