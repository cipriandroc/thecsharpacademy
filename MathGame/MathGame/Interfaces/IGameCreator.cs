namespace MathGame.Interfaces
{
    public interface IGameCreator
    {
        bool userSuccess { get; set; }
        int GetUserResult();
        void StartGame();
    }
}