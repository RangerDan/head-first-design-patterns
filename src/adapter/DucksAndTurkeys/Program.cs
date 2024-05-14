using DucksAndTurkeys.Fowl;

namespace DucksAndTurkeys;

public class Program {
    static void Main(string[] args) {
        IDuck darkwing = new Duck("Darkwing");
        ITurkey benFranklin = new Turkey("Ben Franklin");

        darkwing.Quack();
        benFranklin.Fly();

        List<IDuck> ducksMostFowl = new List<IDuck>
        {
            new Duck("James"),
            new DuckAdapter(new Turkey("William")),
            darkwing,
            new DuckAdapter(benFranklin),
        };

        foreach(var duck in ducksMostFowl) {
            duck.Fly();
            duck.Quack();
        }

        ITurkey donTurkeone = new Turkey("Don Turkeone");
        TurkeyAdapter undercoverDuck = new TurkeyAdapter(new Duck("Undercover Duck"));
        try {
            Console.WriteLine("Don Turkeone invites his newest mook out for a stroll. Can Undercover Duck fit in?");
            donTurkeone.Fly();
            undercoverDuck.Fly();

            donTurkeone.Gobble();
            undercoverDuck.Gobble();

            donTurkeone.FanTail();
            undercoverDuck.FanTail();

            Console.WriteLine("Whew! Looks like he made it.");
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            Console.WriteLine("Looks like it's curtains for Undercover Duck. He couldn't act enough like a duck!");
        }
    }
}