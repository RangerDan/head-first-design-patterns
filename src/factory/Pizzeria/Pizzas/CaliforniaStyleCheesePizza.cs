namespace Pizzeria.Pizzas;

public class CaliforniaStyleCheesePizza : CaliforniaStylePizza {
    public CaliforniaStyleCheesePizza() : base() {
        Name = "Four Cheese";
        Toppings.Add("Jack Cheese");
        Toppings.Add("Parmesean");
        Toppings.Add("Feta Cheese");
    }
}