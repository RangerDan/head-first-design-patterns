using System.Diagnostics.Contracts;
using ThemeController.Devices;

namespace ThemeController.Facades;

public class RentableRoom {
    AmbientLighting Lighting { get; }
    AmbientSound Sound { get; }
    Projector Projector { get; }
    Soundtrack Music { get; }
    TableMod Table {get; }

    public RentableRoom(
        AmbientLighting lighting,
        AmbientSound sound,
        Projector projector,
        Soundtrack music,
        TableMod table)
        {
            Lighting = lighting;
            Sound = sound;
            Projector = projector;
            Music = music;
            Table = table;
        }

    public void DarkDungeonRpg() {
        Lighting.DankDungeon();
        Sound.Oubliette();
        Projector.ShowMedievalDungeon();
        Music.Medieval();
        Table.ProjectedMap();
    }

    public void CyberpunkRpg() {
        Lighting.Vaporwave();
        Sound.CityCenter();
        Projector.ShowCyberpunkDistopia();
        Music.Vaporwave();
        Table.ProjectedMap();
    }

    public void EuropeanBoardGame() {
        Lighting.BrightLighting();
        Sound.Countryside();
        Projector.ShowCountryside();
        Music.Medieval();
        Table.BoardGame();
    }

    public void AmericanBoardGame() {
        Lighting.BrightLighting();
        Sound.CityCenter();
        Projector.Show20sAmerica();
        Music.JungleAdventure();
        Table.BoardGame();
    }

    public void FuturisticWarGame() {
        Lighting.AlienLair();
        Sound.Oubliette();
        Projector.ShowSpaceShip();
        Music.SpaceBase();
        Table.WarGame();
    }
}