using System.Runtime.CompilerServices;

namespace ArmyList.Units;

public interface IListComponent {
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }
    public void Add(IListComponent newComponent);
    public void Remove(int Index);
    public IListComponent GetChild(int index);
    public string ToString();
}