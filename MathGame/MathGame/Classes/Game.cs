using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Classes
{
    public class Game
    {
        public Game() { }
        public void StartGame()
        {
            Console.WriteLine("You have started the game");
            Console.WriteLine("Please make your selection");

            new Choices();
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Substract(int x, int y) 
        { 
            return x - y; 
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }
    }

}
