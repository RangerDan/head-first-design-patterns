namespace StarBuzz.Beverages;

public class Espresso : Beverage {
    public Espresso() {
        Description = "Espresso";
    }

    public override double Cost() {
        return 1.99 + (int) Size * 1.00;
    }
}