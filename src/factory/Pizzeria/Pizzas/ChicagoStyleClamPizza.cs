namespace Pizzeria.Pizzas;

public class ChicagoStyleClamPizza : ChicagoStylePizza {
    public ChicagoStyleClamPizza() : base() {
        Name = "Clam";
        Toppings.Add("Fresh Clams");
    }
}