namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> score = new List<float>();

        public Employee(string name, string surname, int age)
            : base(name, surname, age)
        {
        }
        public Employee(string name, string surname)
            : base(name, surname)
        { 
        }
        public Employee(string name)
            : base(name)
        {
        }

        public void AddScore(float raiting)
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

        public void AddScore(string raiting)
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

        public void AddScore(double raiting)
        {
            float result = (float)raiting;
            this.AddScore(result);     
        }

        public void AddScore(long raiting)
        {
            float result = (float)raiting;
            this.AddScore(result);
        }
        public void AddScore(char raiting)
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
        public Statistics GetStatistics() 
        { 
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue; 

            foreach (var score in this.score) 
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }

            statistics.Average /= this.score.Count;

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }

    }
}

