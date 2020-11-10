namespace GooseGame
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var game = new GooseGame();
            for (var i = 1; i < 66; i++)
                game.PrintSpace(i);
        }
    }
}