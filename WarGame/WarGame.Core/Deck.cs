namespace WarGame.Core;

public class Deck
{
    // We use a Stack to represent the deck, as it allows us to easily draw cards from the top.
    private Stack<Cards> cards = new Stack<Cards>();
    private static Random rand = new Random();

    // The constructor initializes the deck with 52 cards and shuffles it.
    public Deck()
    {
        InitializeDeck();
        Shuffle();
    }

    // This method initializes the deck with 52 standard playing cards.
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

    // This method shuffles the deck using the Fisher-Yates algorithm.
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

    // This method draws a card from the top of the deck.
    // If the deck is empty, it throws an exception.
    public Cards Draw()
    {
        return cards.Pop();
    }

    public int Count => cards.Count;
}