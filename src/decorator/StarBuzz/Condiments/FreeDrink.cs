using StarBuzz.Beverages;

namespace StarBuzz.Condiments;

public class FreeDrink : CondimentDecorator {
    private protected override Beverage _beverage { get; }
    public override string Description { 
        get {
            return _beverage.Description + ", Free";
        }
    }

    public FreeDrink(Beverage beverage) {
        _beverage = beverage;
    }

    public override double Cost() {
        return 0.0;
    }
}