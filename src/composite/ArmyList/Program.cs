using System.Text;
using ArmyList.Units;

namespace ArmyList;

public class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello, Forge World!");

        // Here comes the nerd
        Unit basicUnit1 = new Unit("Ultramarines Squad", "A Squad of Ultramarines with Bolters and lots of Zeal.");
        basicUnit1.Add(new Figure("Ultramarines Sergeant", "Sergeant with Bolt Pistol and Chain Sword",35));
        basicUnit1.Add(new Figure("Space Marine", "Space Marine with Bolter",18));
        basicUnit1.Add(new Figure("Space Marine", "Space Marine with Bolter",18));
        basicUnit1.Add(new Figure("Space Marine", "Space Marine with Bolter",18));
        basicUnit1.Add(new Figure("Space Marine", "Space Marine with Bolter",18));

        Unit basicUnit2 = new Unit("Ultramarines Squad", "A Squad of Ultramarines with Bolters and lots of Zeal.");
        basicUnit2.Add(new Figure("Ultramarines Sergeant", "Sergeant with Bolt Pistol and Chain Sword",35));
        basicUnit2.Add(new Figure("Space Marine", "Space Marine with Bolter",18));
        basicUnit2.Add(new Figure("Space Marine", "Space Marine with Bolter",18));
        basicUnit2.Add(new Figure("Space Marine", "Space Marine with Bolter",18));
        basicUnit2.Add(new Figure("Space Marine", "Space Marine with Bolter",18));

        Unit detachment1 = new Unit("Ultramarines Detachment", "A few units of Ultramarines with a commanding officer");
        detachment1.Add(basicUnit1);
        detachment1.Add(basicUnit2);
        detachment1.Add(new Figure("Ultramarines Chaplain", "Crazy religious guy with a Power Maul and Bolter", 65));

        Unit nerd = new Unit("Nerd Army", "Cheesemaster 5000, a perfectly tailored collection that is way too large");
        nerd.Add(detachment1);
        
        Console.Write(nerd.ToString());
    }
}
