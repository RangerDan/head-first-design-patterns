namespace Pizzeria.Pizzas;

public abstract class Pizza {
    public string Name { get; protected set; } = "None";
    public string Dough { get; protected set; } = "None";
    public string Sauce { get; protected set; } = "None";
    public List<string> Toppings { get; } = new List<string>();

    public void Prepare() {
        Console.WriteLine($"Preparing {Name} pizza");
        Console.WriteLine($"Tossing {Dough} dough...");
        Console.WriteLine($"Adding {Sauce} sauce...");
        if (Toppings.Count > 0) {
            Console.WriteLine("Adding Toppings...");
            foreach (var topping in Toppings) {
                Console.WriteLine($"Topped with {topping}");
            }
        }
    }

    public virtual void Bake() {
        Console.WriteLine("Baking at 350 degrees for that limp crust");
    }
    public virtual void Cut() {
        Console.WriteLine("Cutting like a Lazy Caterer");
    }
    public virtual void Box() {
        Console.WriteLine("Placing into generic box");
    }
}