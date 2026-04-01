namespace WarGame.Core;


public class Card : IComparable<Card>
{
<<<<<<< HEAD

=======
<<<<<<< HEAD
   
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
    public string Suit { get; set; }
    public int Rank { get; set; } // 2–14

<<<<<<< HEAD
    //We can represent suits as strings and ranks as integers (2–14, where 11=J, 12=Q, 13=K, 14=A)
=======
    // Constructor to initialize the card with a suit and rank.
=======
    public string Suit { get; set; }
    public int Rank { get; set; } // 2–14 (Ace = 14)

    
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
    public Card(string suit, int rank)
    {
        Suit = suit;
        Rank = rank;
    }

<<<<<<< HEAD
    // Compare cards by rank for the War game
=======
<<<<<<< HEAD
    // CompareTo method to compare cards based on their rank.
=======
   
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
    public int CompareTo(Card other)
    {
        return Rank.CompareTo(other.Rank);
    }

<<<<<<< HEAD
    // Override ToString for easy display
=======
<<<<<<< HEAD
    // Override ToString to provide a readable representation of the card.
=======
    
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
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


