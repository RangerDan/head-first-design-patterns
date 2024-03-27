namespace Pizzeria.Pizzas;

public abstract class NYStylePizza : Pizza {
    public NYStylePizza() {
        Dough = "Medium";
        Sauce = "Spicy Marinara";
        Toppings.Add("Cheese");
    } 
    public override void Bake() {
        Console.WriteLine("Baking at 500 degrees for a perfect crispy crust");
    }
    public override void Cut() {
        Console.WriteLine("Cutting into 6 big foldable slices");
    }
    public override void Box() {
        Console.WriteLine("Placing into a big box with my custom logo on it");
    }
}