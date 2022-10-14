namespace Lab1;

public class Game
{
    private GameAccount Player { get; }
    public GameAccount Opponent { get; }
    public int Rating { get; }
    private Random winOrLose = new Random();
    private static int StartID = 1234567890;
    public int ID = StartID;
    
    public Game(GameAccount player, GameAccount opponent, int rating)
    {
        Player = player;
        Opponent = opponent;
        Rating = rating;
        ID = StartID;
    }

    public void Play()
    {
        int resultRandom = winOrLose.Next(0, 2);
        if (resultRandom == 0)
        {
            Player.WinGame(Opponent, Rating);
        }
        else
        {
            Player.LoseGame(Opponent, Rating);
        }
        StartID++;
    }
}