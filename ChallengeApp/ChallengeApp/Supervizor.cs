using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Supervizor : EmployeeBase
    {
        private List<float> scoreSupervizors = new List<float>();
        public Supervizor(string name, string surname)
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
        public override void AddScore(int raiting)
        {
            float result = raiting;
            this.AddScore(result);
        }
        public override void AddScore(float raiting)
        {
            if (raiting >= 0 && raiting <= 100)
            {
                this.scoreSupervizors.Add(raiting);
            }
            else
            {
                throw new Exception("Invalid data, use numbers between 0 - 100 ");
            }
        }

        public override void AddScore(string raiting)
        {
            char[] letters = raiting.ToArray();
            int plus = 0;
            int minus = 0;
            int scoreFromLetter = 0;
            if (letters.Length < 3)
            {
                for (int i = 0; i < letters.Length; i++)
                {

                    switch (letters[i])
                    {
                        case '-':
                            minus = -5;
                            break;
                        case '+':
                            plus = 5;
                            break;
                        case '1':
                            plus = 0;
                            break;
                        case '2':
                            plus = 20;
                            break;
                    }
                    for (int k = 3; k < 7; k++)
                    {
                        if (letters[i].ToString() == k.ToString())
                        {
                            scoreFromLetter = k * 10 + (k - 2) * 10;
                        }
                    }

                }
                this.AddScore(scoreFromLetter + plus + minus);

            }
            else
            {
                throw new Exception("Wrong data");
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
                    this.scoreSupervizors.Add(100);
                    break;
                case 'b':
                case 'B':
                    this.scoreSupervizors.Add(80);
                    break;
                case 'c':
                case 'C':
                    this.scoreSupervizors.Add(60);
                    break;
                case 'd':
                case 'D':
                    this.scoreSupervizors.Add(40);
                    break;
                case 'e':
                case 'E':
                    this.scoreSupervizors.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }

        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var score in this.scoreSupervizors)
            {
                statistics.AddGrade(score);
            }

            return statistics;
        }
    }
}
