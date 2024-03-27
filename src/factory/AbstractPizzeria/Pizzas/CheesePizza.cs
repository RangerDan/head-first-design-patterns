using AbstractPizzeria.Factories;
using AbstractPizzeria.Ingredients;

namespace AbstractPizzeria.Pizzas;

public class CheesePizza : Pizza {
    private IPizzaIngredientFactory Factory;

    public CheesePizza(IPizzaIngredientFactory factory) {
        Factory = factory;
    }

    public override void Prepare() {
        Console.WriteLine($"Preparing {Name}");
        Dough = Factory.CreateDough();
        Sauce = Factory.CreateSauce();
        Cheese = Factory.CreateCheese();
    }
}