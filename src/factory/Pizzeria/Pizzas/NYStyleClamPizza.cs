namespace Pizzeria.Pizzas;

public class NYStyleClamPizza : NYStylePizza {
    public NYStyleClamPizza() : base() {
        Name = "Clam";
        Toppings.Add("Clams");
    }
}