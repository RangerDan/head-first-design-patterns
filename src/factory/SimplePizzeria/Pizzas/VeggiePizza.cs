namespace SimplePizzeria.Pizzas;

public class VeggiePizza : Pizza {
    public VeggiePizza() : base() {
        Name = "Veggie";
        Toppings.Add("Green Pepper");
        Toppings.Add("Onions");
        Toppings.Add("Olives");
        Toppings.Add("Canned Tomatoes");
    }
}