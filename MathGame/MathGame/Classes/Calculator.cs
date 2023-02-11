using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGame.Interfaces;

namespace MathGame.Classes
{
    public class Calculator : IGame
    {
        public Calculator() { }
        public void StartGame() { }
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
