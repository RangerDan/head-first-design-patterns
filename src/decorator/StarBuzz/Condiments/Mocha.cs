using StarBuzz.Beverages;

namespace StarBuzz.Condiments;

public class Mocha : CondimentDecorator {
    private protected override Beverage _beverage { get; }
    
    public override string Description { 
        get {
            return _beverage.Description + ", Mocha";
        }
    }

    public Mocha(Beverage beverage) {
        _beverage = beverage;
    }

    public override double Cost() {
        return _beverage.Cost() + 0.20 * (1 + (int) _beverage.Size);
    }
}