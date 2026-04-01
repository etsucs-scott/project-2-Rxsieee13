using WarGame.Core;
namespace WarGame.Core;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        int numPlayers;

=======
<<<<<<< HEAD
        int numPlayers;
        // Prompt the user for the number of players, ensuring it's between 2 and 4.
>>>>>>> origin/main
=======
        int numPlayers;

>>>>>>> WarGame
        do
        {
            Console.Write("Enter number of players (2-4): ");
        }
        while (!int.TryParse(Console.ReadLine(), out numPlayers) || numPlayers < 2 || numPlayers > 4);

        var players = new List<string>();

<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
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
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
>>>>>>> origin/main
=======
>>>>>>> WarGame
        for (int i = 1; i <= numPlayers; i++)
        {
            players.Add($"Player {i}");
        }

        WarGameEngine game = new WarGameEngine(players);
        game.PlayGame();
    }
}