namespace Pizzeria.Pizzas;

public abstract class CaliforniaStylePizza : Pizza {
    public CaliforniaStylePizza() {
        Dough = "Cracker-thin";
        Sauce = "Neopolitan";
        Toppings.Add("Cheese");
    } 
    public override void Bake() {
        Console.WriteLine("Baking at 800 degrees for a perfect cracker in half the time");
    }
    public override void Cut() {
        Console.WriteLine("Cutting into thin long slices so you can fool yourself that you're eating less");
    }
    public override void Box() {
        Console.WriteLine("Placing into a big box with our instragram account featured prominently");
    }
}
