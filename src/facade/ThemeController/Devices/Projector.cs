namespace ThemeController.Devices;

public class Projector {
    public void ShowCountryside() {
        Console.WriteLine("A bucolic countryside is projected onto the walls of the room.");
    }
    
    public void ShowCyberpunkDistopia() {
        Console.WriteLine("A wretched city of neon and smog is projected onto the walls of the room.");
    }

    public void ShowMedievalDungeon() {
        Console.WriteLine("The dank walls of a stone-carved dungeon are projected onto the walls of the room.");
    }
    
    public void Show20sAmerica() {
        Console.WriteLine("The Great Depression hit this town hard. Shanty towns, the Model T, and Lovecraftian Horror are around every corner.");
    }
    
    public void ShowSpaceShip() {
        Console.WriteLine("Corridors and clean lines give way to the darkness of space. The starts twinkle, and the lights flicker nervously.");
    }

    public void Off() {
        Console.WriteLine("Wall projections cease.");
    }
}