using AbstractPizzeria.Ingredients;

namespace AbstractPizzeria.Factories;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory {
    public IDough CreateDough() {
        return new ThinCrustDough();
    }

    public ISauce CreateSauce() {
        return new MarinaraSauce();
    }

    public ICheese CreateCheese() {
        return new ReggianoCheese();
    }

    public IVeggie[] CreateVeggies() {
        IVeggie[] veggies = {
            new Garlic(),
            new Onion(),
            new Mushroom(),
            new RedPepper()
        };

        return veggies;
    }

    public IPepperoni CreatePepperoni() {
        return new SlicedPepperoni();
    }

    public IClams CreateClams() {
        return new FreshClams();
    }
}