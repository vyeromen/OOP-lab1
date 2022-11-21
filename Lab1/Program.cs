namespace Lab1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new GameAccount("Anna");
            var player2 = new GameAccount("Kate");
            var player3 = new GameAccount("Max");
            var player4 = new GameAccount("Alex");

            var game1 = new Game(player1, player3, 5);
            var game2 = new Game(player1, player2, 6);
            var game3 = new Game(player2, player4, 2);
            var game4 = new Game(player3, player1, 7);
            var game5 = new Game(player2, player3, 8);
            var game6 = new Game(player1, player3, 7);
            var game7 = new Game(player4, player1, 2);
            var game8 = new Game(player3, player4, 3);

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