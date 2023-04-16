namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void AddScore(int raiting);
        void AddScore(float raiting);
        void AddScore(string raiting);
        void AddScore(double raiting);
        void AddScore(char raiting);
        Statistics GetStatistics();
    }
}
