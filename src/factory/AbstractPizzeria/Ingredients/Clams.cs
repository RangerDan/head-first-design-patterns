namespace AbstractPizzeria.Ingredients;

public interface IClams {
    string ToString(); 
}

public class FrozenClams : IClams {
    public override string ToString() {
        return "Frozen Clams";
    }
}

public class FreshClams : IClams {
    public override string ToString() {
        return "Fresh Clams";
    }
}