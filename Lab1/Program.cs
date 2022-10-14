namespace Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            GameAccount player1 = new GameAccount("Anna");
            GameAccount player2 = new GameAccount("Kate");
            GameAccount player3 = new GameAccount("Max");
            GameAccount player4 = new GameAccount("Alex");

            Game game1 = new Game(player1, player3, 5);
            Game game2 = new Game(player1, player2, 6);
            Game game3 = new Game(player2, player4, 2);
            Game game4 = new Game(player3, player1, 7);
            Game game5 = new Game(player2, player3, 8);
            Game game6 = new Game(player1, player3, 7);
            Game game7 = new Game(player4, player1, 2);
            Game game8 = new Game(player3, player4, 3);

            game1.Play();
            game2.Play();
            game3.Play();
            game4.Play();
            game5.Play();
            game6.Play();
            game7.Play();
            game8.Play();

            Console.WriteLine(player1.GetStats());
            Console.WriteLine(player2.GetStats());
            Console.WriteLine(player3.GetStats());
            Console.WriteLine(player4.GetStats());
        }
    }
}