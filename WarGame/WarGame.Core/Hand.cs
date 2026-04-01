namespace WarGame.Core;

public class Hand
{
    // We use a Queue to represent the player's hand,
    // as it allows us to easily add cards to the back and play cards from the front.
    private Queue<Cards> cards = new Queue<Cards>();

    public int Count => cards.Count;

    // Adds a single card to the player's hand.
    public void AddCard(Cards card)
    {
        cards.Enqueue(card);
    }

    // Adds multiple cards to the player's hand.
    public void AddCards(List<Cards> newCards)
    {
        foreach (var card in newCards)
        {
            cards.Enqueue(card);
        }
    }

    // Plays a card from the player's hand. Returns null if the hand is empty.
    public Cards PlayCard()
    {
        return cards.Count > 0 ? cards.Dequeue() : null;
    }
}