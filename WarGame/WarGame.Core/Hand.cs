namespace WarGame.Core;


public class Hand
    {
    // We can represent a player's hand as a queue of cards,
    // where they play from the front and add to the back.
    private Queue<Cards> cards = new Queue<Cards>();

        public int Count => cards.Count;

    // This method adds a single card to the player's hand.
    public void AddCard(Cards card)
        {
            cards.Enqueue(card);
        }

    // This method adds multiple cards to the player's hand,
    // which is useful when a player wins a round and collects cards.
    public void AddCards(List<Cards> newCards)
        {
            foreach (var card in newCards)
            {
                cards.Enqueue(card);
            }
        }

    // This method plays a card from the front of the hand.
    public Cards PlayCard()
        {
            return cards.Count > 0 ? cards.Dequeue() : null;
        }
    }