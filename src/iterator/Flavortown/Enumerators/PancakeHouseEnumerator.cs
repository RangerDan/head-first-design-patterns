using System.Collections;
using Flavortown.Menus;

namespace Flavortown.Enumerators;

public class PancakeHouseEnumerator : IEnumerator<MenuItem>
{
    private MenuItem[] _items;
    private int _position;

    public PancakeHouseEnumerator(MenuItem[] items) {
        _items = items;
        _position = 0;
    }

    public MenuItem Current => _items[_position];

    object IEnumerator.Current => _items[_position];

    public void Dispose()
    {
        // Silence is Golden
    }

    public bool MoveNext()
    {
        _position++;
        return _position >= _items.Length;
    }

    public void Reset()
    {
        _position = 0;
    }
}