using WarGame.Core;


class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        // It prompts the user for the number of players and then initializes the game engine.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
        Console.Write("Enter number of players (2-4): ");
        int numPlayers = int.Parse(Console.ReadLine());

        var players = new List<string>();

<<<<<<< HEAD
        // It creates player names based on the number of players entered.
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
        for (int i = 1; i <= numPlayers; i++)
        {
            players.Add($"Player {i}");
        }

        WarGameEngine game = new WarGameEngine(players);
        game.PlayGame();
    }
}