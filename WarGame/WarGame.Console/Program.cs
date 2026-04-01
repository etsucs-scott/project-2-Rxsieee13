using WarGame.Core;
namespace WarGame.Core;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD

        // Prompt the user for the number of players, ensuring it's between 2 and 4.

        int numPlayers;

=======
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
>>>>>>> f0074299dc0d5d4d2dfd1fb53eb6c8f1a182e272
        do
        {
            Console.Write("Enter number of players (2-4): ");
        }
        while (!int.TryParse(Console.ReadLine(), out numPlayers) || numPlayers < 2 || numPlayers > 4);

        var players = new List<string>();

<<<<<<< HEAD

=======
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
<<<<<<< HEAD
>>>>>>> f0074299dc0d5d4d2dfd1fb53eb6c8f1a182e272
        // It prompts the user for the number of players and then initializes the game engine.

        Console.Write("Enter number of players (2-4): ");
        int numPlayers = int.Parse(Console.ReadLine());

        var players = new List<string>();

        // It creates player names based on the number of players entered.
<<<<<<< HEAD

=======
=======
>>>>>>> 0ddcdb0cb3e5cb6c268449a692ecd3b038e994c1
>>>>>>> ed1c0a656273cacbe0efea33f832b2bdf9742309
>>>>>>> origin/main
=======
>>>>>>> WarGame
>>>>>>> f0074299dc0d5d4d2dfd1fb53eb6c8f1a182e272
        for (int i = 1; i <= numPlayers; i++)
        {
            players.Add($"Player {i}");
        }

        WarGameEngine game = new WarGameEngine(players);
        game.PlayGame();
    }
}