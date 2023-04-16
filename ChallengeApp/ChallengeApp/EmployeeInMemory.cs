namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> score = new List<float>();
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
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

            switch (statistics.Average)
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
