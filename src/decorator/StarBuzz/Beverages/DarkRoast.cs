namespace StarBuzz.Beverages;

public class DarkRoast : Beverage {
    public DarkRoast() {
        
        Description = $"Dark Roast Coffee";
    }

    public override double Cost() {
        return 0.99 + (int) Size * 0.20;
    }
}