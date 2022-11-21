namespace Lab1;

public class Game
{
    private GameAccount Player { get; }
    public GameAccount Opponent { get; }
    public int Rating { get; }
    private readonly Random _winOrLose = new();
    private static int _startId = 1234567890;
    public readonly int Id;
    
    public Game(GameAccount player, GameAccount opponent, int rating)
    {
        Player = player;
        Opponent = opponent;
        Rating = rating;
        Id = _startId;
    }

    public void Play()
    {
        var resultRandom = _winOrLose.Next(0, 2);
        if (resultRandom == 0)
        {
            Player.WinGame(Opponent, Rating);
        }
        else
        {
            Player.LoseGame(Opponent, Rating);
        }
        _startId++;
    }
}