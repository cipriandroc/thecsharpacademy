using MathGame.Classes;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameCreator game = new GameCreator();
            game.StartGame();

            bool userWon = game.userSuccess;

            Console.WriteLine($"game won? {userWon}");
        }
    }
}