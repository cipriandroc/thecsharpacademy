using MathGame.Classes;
using MathGame.Functions;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorGame game = new CalculatorGame();
            PlayGameLoop gameLoop = new PlayGameLoop();
            gameLoop.Start(game);
        }
    }
}