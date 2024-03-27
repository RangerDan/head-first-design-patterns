namespace AbstractPizzeria.Ingredients;

public interface ISauce {
    string ToString(); 
}

public class MarinaraSauce : ISauce {
    public override string ToString() {
        return "Marinara Sauce";
    }
}

public class PlumTomatoSauce : ISauce {
    public override string ToString() {
        return "Plum Tomato Sauce";
    }
}