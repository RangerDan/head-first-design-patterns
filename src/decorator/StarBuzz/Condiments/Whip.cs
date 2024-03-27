using StarBuzz.Beverages;

namespace StarBuzz.Condiments;

public class Whip : CondimentDecorator {
    private protected override Beverage _beverage { get; }
    
    public override string Description { 
        get {
            return _beverage.Description + ", Whip";
        }
    }

    public Whip(Beverage beverage) {
        _beverage = beverage;
    }

    public override double Cost() {
        return _beverage.Cost() + 0.25 * (1 + (int) _beverage.Size);
    }
}