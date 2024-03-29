namespace ChocoBoiler.Boilers;

public sealed class ChocolateBoilerLocks {
    private static ChocolateBoilerLocks? _boilerInstance = null;
    private static readonly object boilerLock = new object();
    private bool _empty;
    private bool _boiled;

    private ChocolateBoilerLocks() {
        _empty = true;
        _boiled = false;
    }

    public static ChocolateBoilerLocks Instance {
        get {
            if (_boilerInstance == null) {
                lock(boilerLock) {
                    _boilerInstance = new ChocolateBoilerLocks();
                }
            }

            return _boilerInstance;
        }
    }

    public void Fill() {
        if (_empty) {
            _empty = false;
            _boiled = false;
            Console.WriteLine("Fill: Success!");
            return;
        }

        Console.WriteLine("Fill: Failure! Empty before filling.");
        return;
    }

    public void Drain() {
        if (!_empty && _boiled) {
            _empty = true;
            _boiled = false;
            Console.WriteLine("Drain: Success!");
            return;
        }

        Console.WriteLine("Drain: Failure! Must be full and boiled to drain.");
        return;
    }

    public void Boil() {
        if (!_empty && !_boiled) {
            _boiled = true;
            Console.WriteLine("Boil: Success!");
            return;
        }

        Console.WriteLine("Boil: Failure! Must be full and unboiled.");
        return;
    }
}