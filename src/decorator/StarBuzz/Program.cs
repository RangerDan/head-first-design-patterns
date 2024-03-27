using Utilities;
using StarBuzz.Beverages;
using StarBuzz.Condiments;

namespace StarBuzz;
class Program
{
    static void Main(string[] args)
    {
        ConsoleUtilities.Separator();
        Console.WriteLine("Welcome to this Coffee Stand");
        ConsoleUtilities.Separator();

        Beverage beverage1 = new Espresso();
        Console.WriteLine($"{beverage1.FullDescription()}: {beverage1.Cost().ToString("C")}");

        ConsoleUtilities.Separator();

        Beverage beverage2 = new DarkRoast();
        beverage2.Size = Sizes.TRENTA;
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.FullDescription()}: {beverage2.Cost().ToString("C")}");

        ConsoleUtilities.Separator();

        Beverage beverage3 = new HouseBlend();
        beverage3 = new Soy(beverage3);
        beverage3 = new Honey(beverage3);
        Console.WriteLine($"{beverage3.FullDescription()}: {beverage3.Cost().ToString("C")}");

        ConsoleUtilities.Separator();

        Console.WriteLine($"Total: {(beverage1.Cost()+beverage2.Cost()+beverage3.Cost()).ToString("C")}");
    }
}
