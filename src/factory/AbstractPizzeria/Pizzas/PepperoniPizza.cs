using AbstractPizzeria.Factories;
using AbstractPizzeria.Ingredients;

namespace AbstractPizzeria.Pizzas;

public class PepperoniPizza : Pizza {
    private IPizzaIngredientFactory Factory;

    public PepperoniPizza(IPizzaIngredientFactory factory) {
        Factory = factory;
    }

    public override void Prepare() {
        Console.WriteLine($"Preparing {Name}");
        Dough = Factory.CreateDough();
        Sauce = Factory.CreateSauce();
        Cheese = Factory.CreateCheese();
        Pepperoni = Factory.CreatePepperoni();
    }
}