namespace WarGame.Core
{
    public class Deck
    {
        private Stack<Card> cards = new Stack<Card>();
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

        
        public Card Draw()
        {
            return cards.Pop();
        }

        public int Count => cards.Count;
    }
}
