namespace Flavortown.Menus;

public interface IMenu {
    public string Title { get; }
    public IEnumerable<MenuItem> GetItems();
}