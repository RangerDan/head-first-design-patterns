namespace Pizzeria.Pizzas;

public class ChicagoStyleVeggiePizza : ChicagoStylePizza {
    public ChicagoStyleVeggiePizza() : base() {
        Name = "Veggie";
        Toppings.Add("Green Pepper");
        Toppings.Add("Onions");
        Toppings.Add("Hot peppers");
        Toppings.Add("Poppy Seeds, for some reason");
        Toppings.Add("Fresh Tomatoes");
    }
}