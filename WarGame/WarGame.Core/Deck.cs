namespace WarGame.Core;

public class Deck
{
    private Stack<Cards> cards = new Stack<Cards>();
    private static Random rand = new Random();

    public Deck()
    {
<<<<<<< HEAD
        InitializeDeck();
        Shuffle();
    }
=======
<<<<<<< HEAD
<<<<<<< HEAD
        InitializeDeck();
        Shuffle();
=======
<<<<<<< HEAD
        InitializeDeck();
        Shuffle();
=======
<<<<<<< HEAD
        /// A stack to hold the cards in the deck. The top of the stack is the next card to draw.
        private Stack<Card> cards = new Stack<Card>();
        private static Random rand = new Random();
>>>>>>> f0074299dc0d5d4d2dfd1fb53eb6c8f1a182e272

        private void InitializeDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            foreach (var suit in suits)
            {
                for (int rank = 2; rank <= 14; rank++)
                {
                    cards.Push(new Cards(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            var list = new List<Cards>(cards);
            cards.Clear();

            while (list.Count > 0)
            {
                int index = rand.Next(list.Count);
                cards.Push(list[index]);
                list.RemoveAt(index);
            }
        }

        // Method to draw a card from the top of the deck. Returns null if the deck is empty.

        public Cards Draw()
        {
            return cards.Pop();
        }

        public int Count => cards.Count;
<<<<<<< HEAD

=======
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
>>>>>>> origin/main
=======
        InitializeDeck();
        Shuffle();
>>>>>>> WarGame
    }
>>>>>>> f0074299dc0d5d4d2dfd1fb53eb6c8f1a182e272

    private void InitializeDeck()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        foreach (var suit in suits)
        {
            for (int rank = 2; rank <= 14; rank++)
            {
                cards.Push(new Cards(suit, rank));
            }
        }
    }

    public void Shuffle()
    {
        var list = new List<Cards>(cards);
        cards.Clear();

        while (list.Count > 0)
        {
            int index = rand.Next(list.Count);
            cards.Push(list[index]);
            list.RemoveAt(index);
        }
    }

    public Cards Draw()
    {
        return cards.Pop();
    }

    public int Count => cards.Count;
}