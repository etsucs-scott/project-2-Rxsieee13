using WarGame.Core;
namespace WarGame.Core;

class Program
{
    static void Main(string[] args)
    {
        int numPlayers;

        do
        {
            Console.Write("Enter number of players (2-4): ");
        }
        while (!int.TryParse(Console.ReadLine(), out numPlayers) || numPlayers < 2 || numPlayers > 4);

        var players = new List<string>();

        for (int i = 1; i <= numPlayers; i++)
        {
            players.Add($"Player {i}");
        }

        WarGameEngine game = new WarGameEngine(players);
        game.PlayGame();
    }
}