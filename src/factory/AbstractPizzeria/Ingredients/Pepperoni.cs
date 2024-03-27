namespace AbstractPizzeria.Ingredients;

public interface IPepperoni {
    string ToString(); 
}

public class SlicedPepperoni : IPepperoni {
    public override string ToString() {
        return "Sliced Pepperoni";
    }
}

public class CubedPepperoni : IPepperoni {
    public override string ToString() {
        return "Cubed Pepperoni";
    }
}