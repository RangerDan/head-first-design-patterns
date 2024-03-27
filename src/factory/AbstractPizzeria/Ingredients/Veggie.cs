namespace AbstractPizzeria.Ingredients;

public interface IVeggie {
    string ToString(); 
}

public class Garlic : IVeggie {
    public override string ToString() {
        return "Garlic";
    }
}

public class Onion : IVeggie {
    public override string ToString() {
        return "Onion";
    }
}

public class Mushroom : IVeggie {
    public override string ToString() {
        return "Mushroom";
    }
}

public class RedPepper : IVeggie {
    public override string ToString() {
        return "Red Pepper";
    }
}

public class BlackOlives : IVeggie {
    public override string ToString() {
        return "Black Olives";
    }
}

public class Spinach : IVeggie {
    public override string ToString() {
        return "Spinach";
    }
}

public class Eggplant : IVeggie {
    public override string ToString() {
        return "Eggplant";
    }
}