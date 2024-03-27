namespace Pizzeria.Pizzas;

public class CaliforniaStyleVeggiePizza : CaliforniaStylePizza {
    public CaliforniaStyleVeggiePizza() : base() {
        Name = "Veggie";
        Toppings.Add("Red, Orange and Yellow Peppers");
        Toppings.Add("Red Onions");
        Toppings.Add("Greek Olives");
        Toppings.Add("Nuts");
        Toppings.Add("Sun-dried Tomatoes");
    }
}