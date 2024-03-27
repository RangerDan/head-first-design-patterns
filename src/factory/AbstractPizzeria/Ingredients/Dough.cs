namespace AbstractPizzeria.Ingredients;

public interface IDough {
    string ToString(); 
}

public class ThinCrustDough : IDough {
    public override string ToString() {
        return "Thin Crust Dough";
    }
}

public class ThickCrustDough : IDough {
    public override string ToString() {
        return "Thick Crust Dough";
    }
}