namespace WarGame.Core;


public class Card : IComparable<Card>
{
   
    public string Suit { get; set; }
    public int Rank { get; set; } // 2–14 (Ace = 14)

    // Constructor to initialize the card with a suit and rank.
    public Card(string suit, int rank)
    {
        Suit = suit;
        Rank = rank;
    }

    // CompareTo method to compare cards based on their rank.
    public int CompareTo(Card other)
    {
        return Rank.CompareTo(other.Rank);
    }

    // Override ToString to provide a readable representation of the card.
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


