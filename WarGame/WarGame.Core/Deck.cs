namespace WarGame.Core;

public class Deck
{
    private Stack<Cards> cards = new Stack<Cards>();
    private static Random rand = new Random();

    public Deck()
    {
        InitializeDeck();
        Shuffle();
    }

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