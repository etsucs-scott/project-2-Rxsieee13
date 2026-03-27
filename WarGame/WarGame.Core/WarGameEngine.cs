namespace WarGame.Core;

public class WarGameEngine
{
    // We can represent the game state with a dictionary mapping player names to their hands
    private Dictionary<string, Hand> playerHands = new();
    private List<Card> pot = new();
    private int roundCount = 0;
    private const int MAX_ROUNDS = 10000;

    // The constructor initializes the game by creating a deck,
    // shuffling it, and dealing the cards to the players in a round-robin fashion.
    public WarGameEngine(List<string> players)
    {
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
    }

    // The PlayGame method contains the main game loop, which continues until only one player
    // remains or a maximum number of rounds is reached to prevent infinite loops.
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

    // The PlayRound method handles the logic for each round of the game.
    // It checks for immediate elimination
    private void PlayRound()
    {
        var played = new Dictionary<string, Card>();

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

    // The ResolveRound method determines the winner of the round
    // by comparing the ranks of the played cards.
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
            HandleWar(winners);
        }
    }

    // The HandleWar method manages the "war" scenario when
    // multiple players tie with the same rank.
    private void HandleWar(List<string> tiedPlayers)
    {
        var warCards = new Dictionary<string, Card>();

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

    // The AwardPot method gives all the cards in the pot to the winning player
    // and clears the pot for the next round.
    private void AwardPot(string winner)
    {
        Console.WriteLine($"{winner} wins {pot.Count} cards!");

        playerHands[winner].AddCards(pot);
        pot.Clear();
    }

    // The PrintCardCounts method displays the number of cards each player has after each round
    private void PrintCardCounts()
    {
        Console.WriteLine("Card counts:");
        foreach (var player in playerHands)
        {
            Console.WriteLine($"{player}: {player.Value.Count}");
        }
    }

    // The DeclareWinner method announces the winner of the game when only one player remains
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