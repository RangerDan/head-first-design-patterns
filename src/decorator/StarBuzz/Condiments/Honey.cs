using StarBuzz.Beverages;

namespace StarBuzz.Condiments;

public class Honey : CondimentDecorator {
    private protected override Beverage _beverage { get; }

    public override string Description { 
        get {
            return _beverage.Description + ", Honey";
        }
    }

    public Honey(Beverage beverage) {
        _beverage = beverage;
    }

    public override double Cost() {
        return _beverage.Cost() + 0.15 * (1 + (int) _beverage.Size);
    }
}