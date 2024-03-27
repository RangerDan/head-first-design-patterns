namespace Pizzeria.Pizzas;

public class NYStyleVeggiePizza : NYStylePizza {
    public NYStyleVeggiePizza() : base() {
        Name = "Veggie";
        Toppings.Add("Green Pepper");
        Toppings.Add("Onions");
        Toppings.Add("Olives");
        Toppings.Add("Fresh Tomatoes");
    }
}