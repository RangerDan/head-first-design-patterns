namespace Flavortown.Menus;

public class CafeMenu : IMenu
{
    private Dictionary<string, MenuItem> _items;

    public CafeMenu() {
        _items = new Dictionary<string, MenuItem>
        {
            { "Steak", new MenuItem("Steak", "Porterhouse cooked to your specifications", 24.99, false) },
            { "Chicken Parmesean", new MenuItem("Chicken Parmesean", "A lucious dish of cheese, sauce and pasta with breaded chicken cutlets", 19.99, false) },
            { "Stew", new MenuItem("Vegetable Stew", "Hrmmm, Krusty Burger. That doesn't sound very appetizing.  Do you have any stew?", 5.99, true) }       
        };
    }

    public string Title => "Cafe Menu - For a comfortable evening dining experience";

    public IEnumerable<MenuItem> GetItems()
    {
        return _items.Values;
    }
}