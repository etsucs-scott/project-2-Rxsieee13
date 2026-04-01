namespace WarGame.Core;


public class Cards : IComparable<Cards>
{
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> WarGame

    public string Suit { get; set; }
    public int Rank { get; set; } // 2–14

<<<<<<< HEAD

    //We can represent suits as strings and ranks as integers (2–14, where 11=J, 12=Q, 13=K, 14=A)
    // Constructor to initialize the card with a suit and rank.

    public Cards(string suit, int rank)
=======
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
>>>>>>> origin/main
=======

    //We can represent suits as strings and ranks as integers (2–14, where 11=J, 12=Q, 13=K, 14=A)
    // Constructor to initialize the card with a suit and rank.

    public Cards(string suit, int rank)
>>>>>>> WarGame
    {
        Suit = suit;
        Rank = rank;
    }

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> WarGame

    // Compare cards by rank for the War game
    // CompareTo method to compare cards based on their rank.

    public int CompareTo(Cards other)
<<<<<<< HEAD
=======
<<<<<<< HEAD
    // Compare cards by rank for the War game
=======
<<<<<<< HEAD
    // CompareTo method to compare cards based on their rank.
=======
   
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
    public int CompareTo(Card other)
>>>>>>> origin/main
=======
>>>>>>> WarGame
    {
        return Rank.CompareTo(other.Rank);
    }

<<<<<<< HEAD
<<<<<<< HEAD

    // Override ToString to provide a readable representation of the card.

=======
<<<<<<< HEAD
    // Override ToString for easy display
=======
<<<<<<< HEAD
    // Override ToString to provide a readable representation of the card.
=======
    
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
>>>>>>> origin/main
=======

    // Override ToString to provide a readable representation of the card.

>>>>>>> WarGame
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


