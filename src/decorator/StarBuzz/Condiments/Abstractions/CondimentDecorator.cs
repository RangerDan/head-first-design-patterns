using StarBuzz.Beverages;

namespace StarBuzz.Condiments;

public abstract class CondimentDecorator : Beverage {
    public override Sizes Size { get {
        return _beverage.Size;
    }}

    private protected abstract Beverage _beverage { get; }

    public abstract override string Description { get; }

}