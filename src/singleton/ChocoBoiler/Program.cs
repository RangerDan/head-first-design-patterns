using Utilities;
using ChocoBoiler.Boilers;

namespace ChocoBoiler;

class Program
{
    static void Main(string[] args)
    {
        ChocolateBoilerLocks ref1 = ChocolateBoilerLocks.Instance;
        ChocolateBoilerLocks ref2 = ChocolateBoilerLocks.Instance;

        Console.WriteLine("Playing around with Locking Boilers...");

        if (ref1.GetHashCode() == ref2.GetHashCode()) {
            Console.WriteLine($"Got the same instance of {ref1} with hashcode {ref1.GetHashCode()}");
        }

        ref1.Boil();
        ref2.Fill();
        ref1.Fill();
        ref2.Boil();
        ref1.Boil();
        ref1.Drain();
        ref2.Drain();

        ConsoleUtilities.Separator();

        ChocolateBoilerLazy ref3 = ChocolateBoilerLazy.Instance;
        ChocolateBoilerLazy ref4 = ChocolateBoilerLazy.Instance;

        Console.WriteLine("Playing around with Lazy Boilers...");

        if (ref3.GetHashCode() == ref4.GetHashCode()) {
            Console.WriteLine($"It's the same instance of {ref3} with hashcode {ref3.GetHashCode()}");
        }

        ref3.Boil();
        ref4.Fill();
        ref3.Fill();
        ref4.Boil();
        ref3.Boil();
        ref4.Drain();
        ref3.Drain();

        ChocolateBoilerEnum ref5 = ChocolateBoilerEnum.UNIQUE_INSTANCE;
        ChocolateBoilerEnum ref6 = ChocolateBoilerEnum.UNIQUE_INSTANCE;

        Console.WriteLine("Playing around with Enum Boilers...");

        if (ref5.GetHashCode() == ref6.GetHashCode()) {
            Console.WriteLine($"It's the same instance of {ref5} with hashcode {ref5.GetHashCode()}");
        }

        ref5.Boil();
        ref6.Fill();
        ref5.Fill();
        ref6.Boil();
        ref5.Boil();
        ref6.Drain();
        ref5.Drain();
    }
}