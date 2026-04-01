using WarGame.Core;
namespace WarGame.Core;

class Program
{
    static void Main(string[] args)
    {

        // Prompt the user for the number of players, ensuring it's between 2 and 4.

        int numPlayers;

        do
        {
            Console.Write("Enter number of players (2-4): ");
        }
        while (!int.TryParse(Console.ReadLine(), out numPlayers) || numPlayers < 2 || numPlayers > 4);

        var players = new List<string>();


        // It prompts the user for the number of players and then initializes the game engine.

        Console.Write("Enter number of players (2-4): ");
        int numPlayers = int.Parse(Console.ReadLine());

        var players = new List<string>();

        // It creates player names based on the number of players entered.

        for (int i = 1; i <= numPlayers; i++)
        {
            players.Add($"Player {i}");
        }

        WarGameEngine game = new WarGameEngine(players);
        game.PlayGame();
    }
}