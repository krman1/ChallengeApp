namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) : 
            base(name, surname)
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
                using (var writen = File.AppendText(fileName))
                {
                    writen.WriteLine(raiting);
                }
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
                    using (var writen = File.AppendText(fileName))
                    {
                        writen.WriteLine(100);
                    }
                    break;
                case 'b':
                case 'B':
                    using (var writen = File.AppendText(fileName))
                    {
                        writen.WriteLine(80);
                    }
                    break;
                case 'c':
                case 'C':
                    using (var writen = File.AppendText(fileName))
                    {
                        writen.WriteLine(60);
                    }
                    break;
                case 'd':
                case 'D':
                    using (var writen = File.AppendText(fileName))
                    {
                        writen.WriteLine(40);
                    }
                    break;
                case 'e':
                case 'E':
                    using (var writen = File.AppendText(fileName))
                    {
                        writen.WriteLine(20);
                    }
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            int lineCount = 0;
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string line;
                    while (( line = reader.ReadLine()) != null)
                    {
                        var number = float.Parse(line);
                        Console.WriteLine(line);
                        statistics.Max = Math.Max(statistics.Max, number);
                        statistics.Min = Math.Min(statistics.Min, number);
                        statistics.Average += number;
                        lineCount ++;
                    }   
                }
                statistics.Average /= lineCount;

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

            }
            return statistics;
        }
        public void ClearFile()
        {
            File.WriteAllText(fileName, string.Empty);
        }

    }
}
