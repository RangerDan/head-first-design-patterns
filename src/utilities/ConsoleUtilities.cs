namespace Utilities;

public static class ConsoleUtilities {
    public static void Separator() {
        Console.WriteLine(string.Concat(Enumerable.Repeat("*",50)));
    }
}