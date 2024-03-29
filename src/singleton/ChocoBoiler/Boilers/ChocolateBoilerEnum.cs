namespace ChocoBoiler.Boilers;

public enum ChocolateBoilerEnum {
    UNIQUE_INSTANCE
}

public static class ChocolateBoilerEnumExtensions {
    private static bool _empty = true;
    private static bool _boiled = false;

    public static void Fill(this ChocolateBoilerEnum it) {
        if (_empty) {
            _empty = false;
            _boiled = false;
            Console.WriteLine("Fill: Success!");
            return;
        }

        Console.WriteLine("Fill: Failure! Empty before filling.");
        return;
    }

    public static void Drain(this ChocolateBoilerEnum it) {
        if (!_empty && _boiled) {
            _empty = true;
            _boiled = false;
            Console.WriteLine("Drain: Success!");
            return;
        }

        Console.WriteLine("Drain: Failure! Must be full and boiled to drain.");
        return;
    }

    public static void Boil(this ChocolateBoilerEnum it) {
        if (!_empty && !_boiled) {
            _boiled = true;
            Console.WriteLine("Boil: Success!");
            return;
        }

        Console.WriteLine("Boil: Failure! Must be full and unboiled.");
        return;
    }
}