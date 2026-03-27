namespace WarGame.Core;


public class Card : IComparable<Card>
{

    public string Suit { get; set; }
    public int Rank { get; set; } // 2–14

    //We can represent suits as strings and ranks as integers (2–14, where 11=J, 12=Q, 13=K, 14=A)
    public Card(string suit, int rank)
    {
        Suit = suit;
        Rank = rank;
    }

    // Compare cards by rank for the War game
    public int CompareTo(Card other)
    {
        return Rank.CompareTo(other.Rank);
    }

    // Override ToString for easy display
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


