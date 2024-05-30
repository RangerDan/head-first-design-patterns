using System.Text;

namespace Flavortown.Menus;

public class MenuItem {
    public string Name { get; }
    public string Description { get; }
    public double Price { get; }
    public bool IsVegetarian { get; }

    public MenuItem(string name, string description, double price, bool isVegetarian)
    {
        Name = name;
        Description = description;
        Price = price;
        IsVegetarian = isVegetarian;
    }

    public override string ToString() {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"{Name}: {Price.ToString("C2")}{(IsVegetarian ? " *" : "")}");
        stringBuilder.AppendLine(Description);
        stringBuilder.AppendLine();

        return stringBuilder.ToString();
    }
}