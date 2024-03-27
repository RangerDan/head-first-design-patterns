namespace Pizzeria.Pizzas;

public class CaliforniaStyleClamPizza : CaliforniaStylePizza {
    public CaliforniaStyleClamPizza() : base() {
        Name = "Smoked Clam";
        Toppings.Add("Smoked Clams");
        Toppings.Add("Pesto");
    }
}