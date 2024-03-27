namespace Pizzeria.Pizzas;

public class CaliforniaStylePepperoniPizza : CaliforniaStylePizza {
    public CaliforniaStylePepperoniPizza() : base() {
        Name = "Pepperoni";
        Toppings.Add("Vegan Pepperoni with Fennel and Turmeric");
    }
}