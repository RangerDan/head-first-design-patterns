
namespace Flavortown.Menus;

public class PancakeHouseMenu : IMenu
{
        public MenuItem[] _items;

    public PancakeHouseMenu() {
        _items = new MenuItem[]{
            new MenuItem("Steak and Eggs", "Porterhouse cooked to your specifications", 15.99, false),
            new MenuItem("Ham and Eggs", "A slab of cured pork shoulder and eggs", 10.99, false),
            new MenuItem("Spam and Eggs", "I bet you were expecting a Monty Python joke", 8.99, false)
        };
    }

    public string Title => "Cafe Menu - For a comfortable evening dining experience";

    public IEnumerable<MenuItem> GetItems()
    {
        return _items.AsEnumerable<MenuItem>();
    }
}