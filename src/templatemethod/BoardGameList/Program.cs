using Utilities;

namespace BoardGameList;

public class Program {
    static void Main(string[] args) {
        List<BoardGame> RentalList = new List<BoardGame>() {
            new BoardGame("Monopoly (1935)", 26312),
            new BoardGame("Gloomhaven", 3),
            new BoardGame("The Castles of Burgundy", 16),
            new BoardGame("Brass: Birmingham", 1),
            new BoardGame("Twilight Struggle", 13),
            new BoardGame("Power Grid", 61),
            new BoardGame("Wingspan", 25),
            new BoardGame("Cascadia", 45),
            new BoardGame("Candyland", 24281)
        };

        ConsoleUtilities.Separator();
        Console.WriteLine("Before:");
        ConsoleUtilities.Separator();
        RentalList.ForEach(game => Console.WriteLine($"Name: {game.Name}, Rank: {game.Rank}"));

        RentalList.Sort();

        ConsoleUtilities.Separator();
        Console.WriteLine("After:");
        ConsoleUtilities.Separator();
        RentalList.ForEach(game => Console.WriteLine($"Name: {game.Name}, Rank: {game.Rank}"));
    }
}