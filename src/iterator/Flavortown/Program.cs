using Flavortown.Clients;
using Flavortown.Menus;
using Utilities;

namespace Flavortown;
public class Program {

    static void Main(string[] args) {
        Waitress angeline = new Waitress(new List<IMenu>() {
            new PancakeHouseMenu(),
            new LunchBunchDinerMenu(),
            new CafeMenu(),
        });

        Console.WriteLine("Welome to Flavortown!");
        ConsoleUtilities.Separator();
        Console.WriteLine(angeline.PrintMenus());
        ConsoleUtilities.Separator();
        Console.WriteLine("* Vegetarian");
    }
}