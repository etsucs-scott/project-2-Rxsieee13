namespace WarGame.Core
{
    public class Deck
    {
        /// A stack to hold the cards in the deck. The top of the stack is the next card to draw.
        private Stack<Card> cards = new Stack<Card>();
        private static Random rand = new Random();

        /// Constructor to initialize the deck with 52 cards and shuffle it.
        public Deck()
        {
            InitializeDeck();
            Shuffle();
        }

        // Method to initialize the deck with 52 standard playing cards.
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

        // Method to draw a card from the top of the deck. Returns null if the deck is empty.
        public Card Draw()
        {
            return cards.Pop();
        }

        public int Count => cards.Count;
    }
}
