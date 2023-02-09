namespace MathGame.Interfaces
{
    public interface IGame
    {
        void StartGame();
        int Add(int x, int y);
        int Divide(int x, int y);
        int Multiply(int x, int y);
        int Substract(int x, int y);
    }
}