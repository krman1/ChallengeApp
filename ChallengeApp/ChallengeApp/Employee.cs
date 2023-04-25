namespace ChallengeApp
{
    public class Employee : EmployeeBase

    {
        private List<float> score = new List<float>();

        public Employee(string name, string surname, int age)
            : base(name, surname)
        { 
            this.Age = age;
        }
        public Employee(string name, string surname)
            : base(name, surname)
        {
        }
        public string Name
        {
            get; private set;
        }
        public string Surname
        {
            get; private set;
        }
        public int Age
        {
            get; private set;
        }
        public override void AddScore(int raiting)
        {
            float result = raiting;
            this.AddScore(result);
        }
        public override void AddScore(float raiting)
        {
            if (raiting >= 0 && raiting <= 100)
            {
                this.score.Add(raiting);
            }
            else
            {
                throw new Exception("Invalid data, use numbers between 0 - 100 ");
            }
        }

        public override void AddScore(string raiting)
        {
            if (float.TryParse(raiting, out float result))
            {
                this.AddScore(result);
            }
            else 
            {
                throw new Exception("Wrong string");
            }
        }

        public override void AddScore(double raiting)
        {
            float result = (float)raiting;
            this.AddScore(result);     
        }

        public void AddScore(long raiting)
        {
            float result = (float)raiting;
            this.AddScore(result);
        }
        public override void AddScore(char raiting)
        {
            switch (raiting)
            {
                case 'a':
                case 'A':
                    this.score.Add(100);
                    break;
                case 'b':
                case 'B':
                    this.score.Add(80);
                    break;
                case 'c':
                case 'C':
                    this.score.Add(60);
                    break;
                case 'd':
                case 'D':
                    this.score.Add(40);
                    break;
                case 'e':
                case 'E':
                    this.score.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var score in this.score)
            {
                statistics.AddGrade(score);
            }

            return statistics;
        }

    }
}

