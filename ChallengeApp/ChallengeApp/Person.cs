namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Person(string name)
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
    }
}
