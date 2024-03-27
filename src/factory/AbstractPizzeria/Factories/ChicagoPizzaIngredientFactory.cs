namespace AbstractPizzeria.Factories;
using AbstractPizzeria.Ingredients;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory {
    public IDough CreateDough() {
        return new ThickCrustDough();
    }

    public ISauce CreateSauce() {
        return new PlumTomatoSauce();
    }

    public ICheese CreateCheese() {
        return new MozzarellaCheese();
    }

    public IVeggie[] CreateVeggies() {
        IVeggie[] veggies = {
            new Spinach(),
            new BlackOlives(),
            new Eggplant()
        };

        return veggies;
    }

    public IPepperoni CreatePepperoni() {
        return new SlicedPepperoni();
    }

    public IClams CreateClams() {
        return new FrozenClams();
    }
}