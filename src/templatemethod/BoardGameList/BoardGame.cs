public class BoardGame :IComparable {
    public string Name { get; }
    public int Rank;

    public BoardGame(string name, int rank) {
        Name = name;
        Rank = rank;
    }

    public int CompareTo(Object? obj)
    {
        BoardGame? other = obj as BoardGame;
        
        if (other == null || Rank > other.Rank) {
            return 1;
        } else if (Rank == other.Rank) {
            return 0;
        }
        return -1;
    }
}