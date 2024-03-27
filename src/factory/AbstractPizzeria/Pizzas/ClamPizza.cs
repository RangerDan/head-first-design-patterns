using AbstractPizzeria.Factories;
using AbstractPizzeria.Ingredients;

namespace AbstractPizzeria.Pizzas;

public class ClamPizza : Pizza {
    private IPizzaIngredientFactory Factory;

    public ClamPizza(IPizzaIngredientFactory factory) {
        Factory = factory;
    }

    public override void Prepare() {
        Console.WriteLine($"Preparing {Name}");
        Dough = Factory.CreateDough();
        Sauce = Factory.CreateSauce();
        Cheese = Factory.CreateCheese();
        Clams = Factory.CreateClams();
    }
}
