using MathGame.Classes;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameCreator game = new GameCreator();
            game.StartGame();

            Console.WriteLine($"Your score is: {game.userScore}");

            Console.WriteLine("Play again?");
        }
    }
}