namespace StarBuzz.Beverages;

public class Decaf : Beverage {
    public Decaf() {
        Description = "Decaf Coffee";
    }

    public override double Cost() {
        return 1.09 + (int) Size * 0.25;
    }
}