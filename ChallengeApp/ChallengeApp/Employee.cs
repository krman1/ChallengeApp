namespace ChallengeApp
{
    public class Employee
    {
        private List<float> score = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Employee(string name)
        {
            this.Name = name;
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
        
        public void AddScore(float raiting)
        {
            if (raiting >= 0 && raiting <= 100)
            {
                this.score.Add(raiting);
            }
            else
            {
                Console.WriteLine("Invalid data, use numbers between 0 - 100 ");
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
                Console.WriteLine("Wrong string");
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
            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
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
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i=0; i<score.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, score[i]);
                statistics.Min = Math.Min(statistics.Min, score[i]);
                statistics.Average += score[i];
            }

            statistics.Average /= this.score.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int i = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, score[i]);
                statistics.Min = Math.Min(statistics.Min, score[i]);
                statistics.Average += score[i];
                i++;
            } while (i < score.Count) ;

            statistics.Average /= this.score.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int i = 0;

            while (i < score.Count) 
            {
                statistics.Max = Math.Max(statistics.Max, score[i]);
                statistics.Min = Math.Min(statistics.Min, score[i]);
                statistics.Average += score[i];
                i++;
            } 

            statistics.Average /= this.score.Count;
            return statistics;
        }

    }
}

