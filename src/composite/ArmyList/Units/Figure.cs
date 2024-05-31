using System.Text;

namespace ArmyList.Units;

public class Figure : IListComponent
{
    private string _name;
    private string _description;
    private int _points;

    public Figure(string name, string description, int points) {
        _name = name;
        _description = description;
        _points = points;
    }

    public string Name => _name;

    public string Description => _description;

    public int Points => _points;

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Name} - {Points}pts");
        sb.AppendLine(Description);
        return sb.ToString();
    }

    public void Add(IListComponent newListComponent)
    {
        throw new NotImplementedException();
    }

    public void Remove(int Index)
    {
        throw new NotImplementedException();
    }

    public IListComponent GetChild(int index)
    {
        throw new NotImplementedException();
    }
}