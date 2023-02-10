namespace MathGame.Interfaces
{
    public interface IGameCreator
    {
        int userScore { get; set; }
        void StartGame();
    }
}