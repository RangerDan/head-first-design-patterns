using ThemeController.Devices;
using ThemeController.Facades;

namespace ThemeController;

public class Program {
    static void Main(string[] args) {
        AmbientLighting lighting = new AmbientLighting();
        AmbientSound sound = new AmbientSound();
        Projector projector = new Projector();
        Soundtrack music = new Soundtrack();
        TableMod table = new TableMod();

        Console.WriteLine("Avast! What adventure be ye plannin'?");

        RentableRoom room1 = new RentableRoom(lighting, sound, projector, music, table);

        Console.WriteLine("Maybe we should play Arkham Horror?");
        room1.AmericanBoardGame();
        Console.WriteLine("Or perhaps some Cyberpunk Red?");
        room1.CyberpunkRpg();
        Console.WriteLine("Ah! A dungeon Delve!");
        room1.DarkDungeonRpg();
        Console.WriteLine("The French countryside seems so nice.  Maybe I'll go rent Agricola.");
        room1.EuropeanBoardGame();
        Console.WriteLine("Just kidding. I brought my army and will squash you like a bug!");
        room1.FuturisticWarGame();

        Console.WriteLine("I wonder what this button does?");
        lighting.DankDungeon();
        sound.Jungle();
        projector.Off();
        music.JungleAdventure();
        table.ProjectedMap();
        Console.WriteLine("Fortune and Glory, kid. Fortune and Glory.");
    }
}