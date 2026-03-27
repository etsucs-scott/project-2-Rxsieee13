using WarGame.Core;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of players (2-4): ");
        int numPlayers = int.Parse(Console.ReadLine());

        var players = new List<string>();

        for (int i = 1; i <= numPlayers; i++)
        {
            players.Add($"Player {i}");
        }

        WarGameEngine game = new WarGameEngine(players);
        game.PlayGame();
    }
}