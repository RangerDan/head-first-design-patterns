namespace Pizzeria.Pizzas;

public class NYStylePepperoniPizza : NYStylePizza {
    public NYStylePepperoniPizza() : base() {
        Name = "Pepperoni";
        Toppings.Add("Pepperoni");
    }
}