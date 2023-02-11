using MathGame.Functions;
using MathGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Classes
{
    public class PlayGameLoop
    {

        public void Start(GameCreator game)
        {
            bool playGame = false;

            while (!playGame)

            {
                bool startGame = ParseInputToBool.YesNoLoop("Would you like to start the game?");

                if (startGame)
                {
                    game.StartGame();

                    Console.WriteLine($"Your score is: {game.userScore}");

                    Console.WriteLine("Play again?");
                }
                else
                {
                    Console.WriteLine("gl hf");
                    playGame = true;
                }
            }
        }
    }
}
