namespace Lab1;

public class GameAccount
{
    private string UserName { get; }
    private int CurrentRating 
    {
        get
        {
            var rating = 1;
            foreach(var game in _gamesList)
            {
                if (game.Rating < 0 && rating <= -(game.Rating))
                    rating = 1;
                else rating += game.Rating;
            }
            return rating;
        }
    }

    private readonly List<Game> _gamesList = new();

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

        var game = new Game(this, opponent, rating);
        _gamesList.Add(game);
        
        game = new Game(opponent, this, -rating);
        opponent._gamesList.Add(game);
    }
    
    public void LoseGame(GameAccount opponent, int rating)
    {
        if (rating < 0)
        {
            throw new ArgumentOutOfRangeException("Rating must be positive");
        }
        
        var game = new Game(this, opponent, -rating);
        _gamesList.Add(game);
        
        game = new Game(opponent,this, rating);
        opponent._gamesList.Add(game);
    }

    public string GetStats()
    {
        var report = new System.Text.StringBuilder();
        report.AppendLine();
        report.AppendLine($"\t\t\t\tStats for {UserName}");
        report.AppendLine("___________________________________________________________________________");
        report.AppendLine("       ID             Player          Opponent          Rating    ");
        report.AppendLine("---------------------------------------------------------------------------");
        
        foreach (var game in _gamesList)
        {
            report.AppendLine($"{game.Id, 13}  {UserName, 12}  {game.Opponent.UserName, 15}  {game.Rating, 14}");
            report.AppendLine("---------------------------------------------------------------------------");
        }
        
        report.AppendLine($"Total Games Played: {_gamesList.Count}");
        report.AppendLine($"Final Rating: {CurrentRating}");
        return report.ToString();
    }
}