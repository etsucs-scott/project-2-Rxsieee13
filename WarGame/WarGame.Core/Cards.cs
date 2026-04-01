namespace WarGame.Core;


public class Cards : IComparable<Cards>
{
    public string Suit { get; set; }
    public int Rank { get; set; } // 2–14

    // Constructor to initialize the card with a suit and rank
    public Cards(string suit, int rank)
    {
        Suit = suit;
        Rank = rank;
    }

    // Implement IComparable to allow sorting by rank
    public int CompareTo(Cards other)
    {
        return Rank.CompareTo(other.Rank);
    }

    // Override ToString to display the card in a readable format (e.g., "10 of Hearts", "A of Spades")
    public override string ToString()
    {
        return Rank switch
        {
            11 => "J",
            12 => "Q",
            13 => "K",
            14 => "A",
            _ => Rank.ToString()
        };
    }
}


