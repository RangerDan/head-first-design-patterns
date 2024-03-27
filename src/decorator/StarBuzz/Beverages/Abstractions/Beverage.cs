namespace StarBuzz.Beverages;

public abstract class Beverage {
    public virtual Sizes Size { get; set; } = Sizes.TALL;
    public virtual string Description { get; protected set; } = "Unknown Beverage";

    public string FullDescription() {
        return SizeDescription() + " " + Description;
    }

    public abstract double Cost();

    private protected string SizeDescription() {
        switch (Size) {
            case Sizes.GRANDE:
                return "Grande";
            case Sizes.VENTI:
                return "Venti";
            case Sizes.TRENTA:
                return "Trenta";
        }
        
        return "Tall";    
    }
}