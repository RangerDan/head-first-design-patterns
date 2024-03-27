using System;
using AbstractPizzeria.Ingredients;

namespace AbstractPizzeria.Pizzas;

public abstract class Pizza {
    public string Name { get; set; } = "None";
    public IDough? Dough { get; protected set; }
    public ISauce? Sauce { get; protected set; }
    public IVeggie[]? Veggies { get; protected set; }
    public ICheese? Cheese { get; protected set; }
    public IPepperoni? Pepperoni { get; protected set; }
    public IClams? Clams { get; protected set; }

    public abstract void Prepare();

    public virtual void Bake() {
        Console.WriteLine("Baking at 400 degrees");
    }
    public virtual void Cut() {
        Console.WriteLine("Cutting into generous slices");
    }
    public virtual void Box() {
        Console.WriteLine("Placing into AbstractPizzeria Boxes");
    }

    public override string ToString() {
        string description = Name + Environment.NewLine;
        if (Dough != null) {
            description += "on a base of " + Dough + Environment.NewLine;
        }
        if (Sauce != null) {
            description += "with plenty of " + Sauce + Environment.NewLine;
        }
        if (Cheese != null) {
            description += "covered in " + Cheese + Environment.NewLine;
        }
        if (Pepperoni != null) {
            description += "and heaps of " + Pepperoni + Environment.NewLine;
        }
        if (Veggies != null) {
            description += "with roasted... " + Environment.NewLine;
            foreach(var veg in Veggies) {
                description += " " + veg + Environment.NewLine;
            }
        }
        if (Clams != null) {
            description += "a taste of " + Clams + Environment.NewLine;
        } 

        return description;
    }
}