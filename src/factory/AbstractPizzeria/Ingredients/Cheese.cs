namespace AbstractPizzeria.Ingredients;

public interface ICheese {
    string ToString();
}

public class ReggianoCheese : ICheese {
    public override string ToString() {
        return "Reggiano Cheese";
    }
}

public class MozzarellaCheese : ICheese {
    public override string ToString() {
        return "Mozzarella Cheese";
    }
}