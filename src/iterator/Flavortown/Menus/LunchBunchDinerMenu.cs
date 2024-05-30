
namespace Flavortown.Menus;

class LunchBunchDinerMenu : IMenu
{
    public readonly List<MenuItem> _items;

    public LunchBunchDinerMenu()
    {
        _items = new List<MenuItem>() {
            new MenuItem("Reuben", "Rye, Pastrami, Kraut, Swiss, Dressing. Need I say more?", 14.99,false),
            new MenuItem("Fish and Chips", "Just like me mum used to make.", 10.99, false),
            new MenuItem("Chef's Salad", "Iceberg, dressing, cherry tomatoes", 5.99, true),
        };
    }

    public string Title => "Lunch Bunch Diner: Ready to Serve You!";

    public IEnumerable<MenuItem> GetItems()
    {
        return _items;
    }
}