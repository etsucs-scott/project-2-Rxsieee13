namespace WarGame.Core;

public class WarGameEngine
{
      
    private Dictionary<string, Queue<Card>> playerHands = new();
    private List<Card> pot = new();
    private int roundCount = 0;
    private const int MAX_ROUNDS = 10000;

    public WarGameEngine(List<string> players)
    {
        Deck deck = new Deck();

        foreach (var player in players)
        {
            playerHands[player] = new Queue<Card>();
        }

        // Round-robin dealing
        int i = 0;
        while (deck.Count > 0)
        {
            var player = players[i % players.Count];
            playerHands[player].Enqueue(deck.Draw());
            i++;
        }
    }

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

    private void AwardPot(string winner)
    {
        Console.WriteLine($"{winner} wins the round and takes {pot.Count} cards!");

        foreach (var card in pot)
        {
            playerHands[winner].Enqueue(card);
        }

        pot.Clear();
    }

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