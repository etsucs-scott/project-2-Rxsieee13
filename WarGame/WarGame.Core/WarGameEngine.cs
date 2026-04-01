namespace WarGame.Core;

public class WarGameEngine
{
<<<<<<< HEAD

    // A dictionary to hold each player's hand of cards.
    // The key is the player's name, and the value is a queue of cards representing their hand.

        private Dictionary<string, Hand> playerHands = new();
        private List<Cards> pot = new();
        private int roundCount = 0;
        private const int MAX_ROUNDS = 10000;

    // The constructor initializes the game
    // by creating a deck of cards, shuffling it, and dealing it to the players in a round-robin fashion.
=======
<<<<<<< HEAD
    // We can represent the game state with a dictionary mapping player names to their hands
    private Dictionary<string, Hand> playerHands = new();
=======
<<<<<<< HEAD
    // A dictionary to hold each player's hand of cards.
    // The key is the player's name, and the value is a queue of cards representing their hand.
=======
      
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
    private Dictionary<string, Queue<Card>> playerHands = new();
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
    private List<Card> pot = new();
    private int roundCount = 0;
    private const int MAX_ROUNDS = 10000;

<<<<<<< HEAD
    // The constructor initializes the game by creating a deck,
    // shuffling it, and dealing the cards to the players in a round-robin fashion.
=======
<<<<<<< HEAD
    
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
>>>>>>> origin/main
    public WarGameEngine(List<string> players)
        {
<<<<<<< HEAD
            Deck deck = new Deck();

            foreach (var player in players)
            {
                playerHands[player] = new Hand();
            }

            // Round-robin dealing
            int i = 0;
            while (deck.Count > 0)
            {
                var player = players[i % players.Count];
                playerHands[player].AddCard(deck.Draw());
                i++;
            }
=======
            playerHands[player] = new Hand();
        }
<<<<<<< HEAD
        
        // Round-robin dealing
=======

<<<<<<< HEAD
        // Deal cards to players in a round-robin fashion until the deck is empty.
=======
        // Round-robin dealing
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
        int i = 0;
        while (deck.Count > 0)
        {
            var player = players[i % players.Count];
            playerHands[player].AddCard(deck.Draw());
            i++;
        }
    }

<<<<<<< HEAD
    // The PlayGame method contains the main game loop, which continues until only one player
    // remains or a maximum number of rounds is reached to prevent infinite loops.
=======
<<<<<<< HEAD
    // The main game loop that continues until there is only one player left
    // or the maximum number of rounds is reached.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
    public void PlayGame()
    {
        while (playerHands.Count > 1 && roundCount < MAX_ROUNDS)
        {
            roundCount++;
            Console.WriteLine($"\n--- Round {roundCount} ---");

            PlayRound();
            PrintCardCounts();
>>>>>>> origin/main
        }

    
        public void PlayGame()
        {
            while (playerHands.Count > 1 && roundCount < MAX_ROUNDS)
            {
                roundCount++;
                Console.WriteLine($"\n--- Round {roundCount} ---");

                PlayRound();
                PrintCardCounts();
            }

            DeclareWinner();
        }

<<<<<<< HEAD
    // The PlayRound method handles the logic for each round of the game.
=======
<<<<<<< HEAD
    // The PlayRound method handles the logic for each round of the game.
    // It checks for immediate elimination
=======
<<<<<<< HEAD
    // This method handles the logic for playing a single round of the game.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
>>>>>>> origin/main
    private void PlayRound()
        {
            var played = new Dictionary<string, Cards>();

            // Immediate elimination check
            foreach (var player in playerHands.Keys.ToList())
            {
                if (playerHands[player].Count == 0)
                {
                    Console.WriteLine($"{player} eliminated!");
                    playerHands.Remove(player);
                    continue;
                }

                var card = playerHands[player].PlayCard();
                played[player] = card;
                pot.Add(card);

                Console.WriteLine($"{player}: {card}");
            }

            Console.WriteLine("Pot: " + string.Join(", ", pot));

            ResolveRound(played);
        }

<<<<<<< HEAD
    // The ResolveRound method determines the winner of the round based on the cards played.
    private void ResolveRound(Dictionary<string, Cards> played)
=======
        Console.WriteLine("Pot: " + string.Join(", ", pot));

        ResolveRound(played);
    }

<<<<<<< HEAD
    // The ResolveRound method determines the winner of the round
    // by comparing the ranks of the played cards.
=======
<<<<<<< HEAD
    // This method determines the winner of the round based on the cards played.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
    private void ResolveRound(Dictionary<string, Card> played)
    {
        int maxRank = played.Values.Max(c => c.Rank);

        var winners = played
            .Where(p => p.Value.Rank == maxRank)
            .Select(p => p.Key)
            .ToList();

        if (winners.Count == 1)
>>>>>>> origin/main
        {
            int maxRank = played.Values.Max(c => c.Rank);

<<<<<<< HEAD
            var winners = played
                .Where(p => p.Value.Rank == maxRank)
                .Select(p => p.Key)
                .ToList();

            if (winners.Count == 1)
            {
                AwardPot(winners[0]);
            }
            else
            {
                Console.WriteLine("Tie between: " + string.Join(", ", winners));
                HandleWar(winners);
            }
        }

    // The HandleWar method manages the "war" scenario when multiple players tie with the same rank.
=======
<<<<<<< HEAD
    // The HandleWar method manages the "war" scenario when
    // multiple players tie with the same rank.
=======
<<<<<<< HEAD
    // This method handles the "WAR" scenario when there is a tie between players.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
>>>>>>> origin/main
    private void HandleWar(List<string> tiedPlayers)
        {
            var warCards = new Dictionary<string, Cards>();

            foreach (var player in tiedPlayers.ToList())
            {
                if (playerHands[player].Count == 0)
                {
                    Console.WriteLine($"{player} eliminated during WAR!");
                    tiedPlayers.Remove(player);
                    continue;
                }

                var card = playerHands[player].PlayCard();
                warCards[player] = card;
                pot.Add(card);

                Console.WriteLine($"{player} WAR card: {card}");
            }

            Console.WriteLine("Pot now: " + string.Join(", ", pot));

            if (tiedPlayers.Count == 1)
            {
                AwardPot(tiedPlayers[0]);
                return;
            }

            ResolveRound(warCards);
        }

<<<<<<< HEAD
    // The AwardPot method gives all the cards in the pot
    // to the winning player and clears the pot for the next round.
    private void AwardPot(string winner)
=======
        Console.WriteLine("Pot now: " + string.Join(", ", pot));

        if (tiedPlayers.Count == 1)
        {
            AwardPot(tiedPlayers[0]);
            return;
        }

        ResolveRound(warCards);
    }

<<<<<<< HEAD
    // The AwardPot method gives all the cards in the pot to the winning player
    // and clears the pot for the next round.
=======
<<<<<<< HEAD
    // This method awards the pot of cards to the winner of the round.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
    private void AwardPot(string winner)
    {
        Console.WriteLine($"{winner} wins {pot.Count} cards!");

        playerHands[winner].AddCards(pot);
        pot.Clear();
    }

<<<<<<< HEAD
    // The PrintCardCounts method displays the number of cards each player has after each round
=======
<<<<<<< HEAD
    
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
    private void RemoveEliminatedPlayers()
    {
        var eliminated = playerHands
            .Where(p => p.Value.Count == 0)
            .Select(p => p.Key)
            .ToList();

        foreach (var player in eliminated)
>>>>>>> origin/main
        {
            Console.WriteLine($"{winner} wins {pot.Count} cards!");

<<<<<<< HEAD
            playerHands[winner].AddCards(pot);
            pot.Clear();
        }

    // The PrintCardCounts method displays the number of cards each player has after each round,
    // which helps track the game's progress.
=======
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
>>>>>>> origin/main
    private void PrintCardCounts()
        {
            Console.WriteLine("Card counts:");
            foreach (var player in playerHands)
            {
                Console.WriteLine($"{player}: {player.Value.Count}");
            }
        }

<<<<<<< HEAD
    // The DeclareWinner method determines and announces the winner of the game once it concludes
=======
<<<<<<< HEAD
    // The DeclareWinner method announces the winner of the game when only one player remains
=======
<<<<<<< HEAD
    // Declares the winner based on who has the most cards at the end or all the cards or
    // if the round limit is reached.
=======
    
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
>>>>>>> origin/main
    private void DeclareWinner()
        {
            if (playerHands.Count == 1)
            {
                Console.WriteLine($"\n Winner: {playerHands.Keys.First()}");
                return;
            }

            Console.WriteLine("\nReached round limit!");

            int maxCards = playerHands.Max(p => p.Value.Count);

            var winners = playerHands
                .Where(p => p.Value.Count == maxCards)
                .ToList();

            if (winners.Count > 1)
            {
                Console.WriteLine("Game is a DRAW!");
            }
            else
            {
                Console.WriteLine($"Winner: {winners[0].Key}");
            }
        }
}