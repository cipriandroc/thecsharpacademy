using MathGame.Classes;
using MathGame.Functions;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCreator game = new GameCreator();
            PlayGameLoop gameLoop = new PlayGameLoop();
            gameLoop.Start(game);
        }
    }
}