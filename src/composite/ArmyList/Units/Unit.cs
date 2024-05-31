using System.Text;

namespace ArmyList.Units;

public class Unit : IListComponent
{
    private string _name;
    private string _description;

    IList<IListComponent> _components;

    public Unit(string name, string description) {
        _name = name;
        _description = description;
        _components = new List<IListComponent>();
    }

    public string Name => _name;

    public string Description => _description;

    public int Points => _components.Sum(fig => fig.Points);

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Name} - {Points}pts");
        sb.AppendLine(Description);
        foreach(var thing in _components) {
            sb.Append(thing.ToString());
        }
        return sb.ToString();
    }

    public void Add(IListComponent newListComponent)
    {
        _components.Add(newListComponent);
    }

    public void Remove(int index)
    {
        _components.RemoveAt(index);
    }

    public IListComponent GetChild(int index)
    {
        return _components[index];
    }
}