namespace Lab1;

public class GameAccount
{
    private string UserName { get; }
    private int CurrentRating 
    {
        get
        {
            int rating = 1;
            foreach(Game game in GamesList)
            {
                if (game.Rating < 0 && rating <= -(game.Rating))
                    rating = 1;
                else rating += game.Rating;
            }
            return rating;
        }
    }

    private int GamesCount => GamesList.Count;

    private List<Game> GamesList = new List<Game>();

    public GameAccount(string name)
    {
        UserName = name;
    }

    public void WinGame(GameAccount opponent, int rating)
    {
        if (rating < 0)
        {
            throw new ArgumentOutOfRangeException("Rating must be positive");
        }

        Game game = new Game(this, opponent, rating);
        GamesList.Add(game);
        
        game = new Game(opponent, this, -rating);
        opponent.GamesList.Add(game);
    }
    
    public void LoseGame(GameAccount opponent, int rating)
    {
        if (rating < 0)
        {
            throw new ArgumentOutOfRangeException("Rating must be positive");
        }
        
        Game game = new Game(this, opponent, -rating);
        GamesList.Add(game);
        
        game = new Game(opponent,this, rating);
        opponent.GamesList.Add(game);
    }

    public string GetStats()
    {
        var report = new System.Text.StringBuilder();
        report.AppendLine();
        report.AppendLine($"\t\t\t\tStats for {UserName}");
        report.AppendLine("___________________________________________________________________________");
        report.AppendLine("       ID             Player          Opponent          Rating    ");
        report.AppendLine("---------------------------------------------------------------------------");
        
        foreach (Game game in GamesList)
        {
            report.AppendLine($"{game.ID, 13}  {UserName, 12}  {game.Opponent.UserName, 15}  {game.Rating, 14}");
            report.AppendLine("---------------------------------------------------------------------------");
        }
        
        report.AppendLine($"Total Games Played: {GamesCount}");
        report.AppendLine($"Final Rating: {CurrentRating}");
        return report.ToString();
    }
}