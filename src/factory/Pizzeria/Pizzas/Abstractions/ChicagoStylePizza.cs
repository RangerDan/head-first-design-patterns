namespace Pizzeria.Pizzas;

public abstract class ChicagoStylePizza : Pizza {
    public ChicagoStylePizza() {
        Dough = "Thick";
        Sauce = "Thick Marinara";
        Toppings.Add("Cheese (Thick)");
    } 
    public override void Bake() {
        Console.WriteLine("Baking at 350 degrees like a casserole");
    }
    public override void Cut() {
        Console.WriteLine("Cutting into squares like a casserole");
    }
    public override void Box() {
        Console.WriteLine("Placing into a big takeout box like a casserole");
    }
}