namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name
        {
            get; private set;
        }
        public string Surname
        {
            get; private set;
        }
        public abstract void AddScore(int raiting);
        public abstract void AddScore(float raiting);
        public abstract void AddScore(string raiting);
        public abstract void AddScore(double raiting);
        public abstract void AddScore(char raiting);
        public abstract Statistics GetStatistics();
       
    }
}
