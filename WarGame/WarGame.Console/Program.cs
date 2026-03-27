using WarGame.Core;

class Program
{
    static void Main(string[] args)
    {
        int numPlayers;
        // Prompt the user for the number of players, ensuring it's between 2 and 4.
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

        // Initialize the game with the specified players and start the game loop.
        WarGame game = new WarGame(players);
        game.PlayGame();
    }
}