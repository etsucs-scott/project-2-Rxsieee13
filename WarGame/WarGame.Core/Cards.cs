namespace WarGame.Core;


public class Cards : IComparable<Cards>
{
    //We can represent suits as strings and ranks as integers
    //(2–14, where 11=J, 12=Q, 13=K, 14=A)
    public string Suit { get; set; }
    public int Rank { get; set; }


    public Cards(string suit, int rank)
    {
        Suit = suit;
        Rank = rank;
    }

    // Compare cards by rank for the War game

    public int CompareTo(Cards other)
    {
        return Rank.CompareTo(other.Rank);
    }

    // Override ToString to provide a readable representation of the card.
    public override string ToString() => Rank switch
    {
        11 => "J",
        12 => "Q",
        13 => "K",
        14 => "A",
          _ => Rank.ToString()
    };
}


