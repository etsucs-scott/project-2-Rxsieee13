namespace WarGame.Core;

public class WarGameEngine
{
<<<<<<< HEAD
    // A dictionary to hold each player's hand of cards.
    // The key is the player's name, and the value is a queue of cards representing their hand.
=======
      
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
    private Dictionary<string, Queue<Card>> playerHands = new();
    private List<Card> pot = new();
    private int roundCount = 0;
    private const int MAX_ROUNDS = 10000;

<<<<<<< HEAD
    
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
    public WarGameEngine(List<string> players)
    {
        Deck deck = new Deck();

        foreach (var player in players)
        {
            playerHands[player] = new Queue<Card>();
        }

<<<<<<< HEAD
        // Deal cards to players in a round-robin fashion until the deck is empty.
=======
        // Round-robin dealing
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
        int i = 0;
        while (deck.Count > 0)
        {
            var player = players[i % players.Count];
            playerHands[player].Enqueue(deck.Draw());
            i++;
        }
    }

<<<<<<< HEAD
    // The main game loop that continues until there is only one player left
    // or the maximum number of rounds is reached.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
    public void PlayGame()
    {
        while (playerHands.Count > 1 && roundCount < MAX_ROUNDS)
        {
            roundCount++;
            Console.WriteLine($"\n--- Round {roundCount} ---");

            PlayRound();
            RemoveEliminatedPlayers();
            PrintCardCounts();
        }

        DeclareWinner();
    }

<<<<<<< HEAD
    // This method handles the logic for playing a single round of the game.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
    private void PlayRound()
    {
        var played = new Dictionary<string, Card>();

        foreach (var player in playerHands.Keys.ToList())
        {
            if (playerHands[player].Count > 0)
            {
                var card = playerHands[player].Dequeue();
                played[player] = card;
                pot.Add(card);

                Console.WriteLine($"{player}: {card}");
            }
        }

        Console.WriteLine("Pot includes: " + string.Join(", ", pot));

        ResolveRound(played);
    }

<<<<<<< HEAD
    // This method determines the winner of the round based on the cards played.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
    private void ResolveRound(Dictionary<string, Card> played)
    {
        int maxRank = played.Values.Max(c => c.Rank);

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
            Console.WriteLine("WAR!");

            HandleWar(winners);
        }
    }

<<<<<<< HEAD
    // This method handles the "WAR" scenario when there is a tie between players.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
    private void HandleWar(List<string> tiedPlayers)
    {
        var warCards = new Dictionary<string, Card>();

        foreach (var player in tiedPlayers.ToList())
        {
            if (playerHands[player].Count == 0)
            {
                Console.WriteLine($"{player} eliminated (no cards for WAR)");
                tiedPlayers.Remove(player);
                continue;
            }

            var card = playerHands[player].Dequeue();
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
    // This method awards the pot of cards to the winner of the round.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
    private void AwardPot(string winner)
    {
        Console.WriteLine($"{winner} wins the round and takes {pot.Count} cards!");

        foreach (var card in pot)
        {
            playerHands[winner].Enqueue(card);
        }

        pot.Clear();
    }

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
        {
            Console.WriteLine($"{player} is eliminated!");
            playerHands.Remove(player);
        }
    }

    private void PrintCardCounts()
    {
        Console.WriteLine("Card counts:");
        foreach (var player in playerHands)
        {
            Console.WriteLine($"{player}: {player.Value.Count}");
        }
    }

<<<<<<< HEAD
    // Declares the winner based on who has the most cards at the end or all the cards or
    // if the round limit is reached.
=======
    
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
    private void DeclareWinner()
    {
        if (playerHands.Count == 1)
        {
            Console.WriteLine($"\n Winner: {playerHands.Keys.First()}");
        }
        else
        {
            Console.WriteLine("\nReached round limit!");

            var winner = playerHands
                .OrderByDescending(p => p.Value.Count)
                .First();

            Console.WriteLine($"Winner by card count: {winner.Key}");

            if (playerHands.Values.Select(p => p.Count).Distinct().Count() == 1)
            {
                Console.WriteLine("Game is a DRAW!");
            }
        }
    }
}