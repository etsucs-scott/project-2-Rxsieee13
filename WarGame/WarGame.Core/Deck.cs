namespace WarGame.Core;

public class Deck
{
    // We can represent the deck as a stack of cards
    // where we draw from the top and add to the bottom when shuffling.
    private Stack<Card> cards = new Stack<Card>();
    private static Random rand = new Random();

    // Initialize the deck with 52 cards and shuffle it
    public Deck()
    {
        InitializeDeck();
        Shuffle();
    }

    // This method creates a standard deck of 52 playing cards.
    private void InitializeDeck()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        foreach (var suit in suits)
        {
            for (int rank = 2; rank <= 14; rank++)
            {
                cards.Push(new Card(suit, rank));
            }
        }
    }

    // This method shuffles the deck using a simple randomization algorithm.
    public void Shuffle()
    {
        var list = new List<Card>(cards);
        cards.Clear();

        while (list.Count > 0)
        {
            int index = rand.Next(list.Count);
            cards.Push(list[index]);
            list.RemoveAt(index);
        }
    }

    // This method draws a card from the top of the deck.
    public Card Draw()
    {
        return cards.Pop();
    }

    // This property returns the number of cards currently in the deck.
    public int Count => cards.Count;
}