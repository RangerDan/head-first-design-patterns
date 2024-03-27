namespace Pizzeria.Pizzas;

public class ChicagoStyleCheesePizza : ChicagoStylePizza {
    public ChicagoStyleCheesePizza() : base() {
        Name = "Cheese";
        Toppings.Add("More Cheese");
        Toppings.Add("Oh god, please stop with the cheese");
        Toppings.Add("+++flatline+++");
    }
}