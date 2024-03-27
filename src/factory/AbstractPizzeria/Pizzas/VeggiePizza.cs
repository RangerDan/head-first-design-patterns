using AbstractPizzeria.Factories;
using AbstractPizzeria.Ingredients;

namespace AbstractPizzeria.Pizzas;

public class VeggiePizza : Pizza {
    private IPizzaIngredientFactory Factory;

    public VeggiePizza(IPizzaIngredientFactory factory) {
        Factory = factory;
    }

    public override void Prepare() {
        Console.WriteLine($"Preparing {Name}");
        Dough = Factory.CreateDough();
        Sauce = Factory.CreateSauce();
        Cheese = Factory.CreateCheese();
        Veggies = Factory.CreateVeggies();
    }
}