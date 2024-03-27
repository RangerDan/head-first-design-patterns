using StarBuzz.Beverages;

namespace StarBuzz.Condiments;

public class Soy : CondimentDecorator {
    private protected override Beverage _beverage { get; }
    
    public override string Description { 
        get {
            return _beverage.Description + ", Soy";
        }
    }

    public Soy(Beverage beverage) {
        _beverage = beverage;
    }

    public override double Cost() {
        return _beverage.Cost() + 0.10 * (1 + (int) _beverage.Size);
    }
}