using System.Text;
using Flavortown.Menus;

namespace Flavortown.Clients;

public class Waitress {
    private IEnumerable<IMenu> _menus;

    public Waitress(IEnumerable<IMenu> menus) {
        _menus = menus;
    }

    public string PrintMenus() {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Here is a list of today's specials:");
        foreach(var menu in _menus) {
            sb.AppendLine(menu.Title);
            sb.AppendLine("--------------------------------------------");
            
            foreach(var item in menu.GetItems()) {
                sb.Append(item.ToString());
            }
        }

        return sb.ToString();
    }
}