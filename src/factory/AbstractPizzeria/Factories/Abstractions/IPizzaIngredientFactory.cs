using AbstractPizzeria.Ingredients;

namespace AbstractPizzeria.Factories;

public interface IPizzaIngredientFactory {
    public IDough CreateDough();
    public ISauce CreateSauce();
    public ICheese CreateCheese();
    public IVeggie[] CreateVeggies();
    public IPepperoni CreatePepperoni();
    public IClams CreateClams();
}