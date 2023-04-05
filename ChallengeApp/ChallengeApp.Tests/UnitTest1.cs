namespace ChallengeApp.Tests
{
    public class Tests
    {
    
        [Test]
        public void AddScoreWithStringTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore("3");
            employee.AddScore(8);
            employee.AddScore(2);

            // act
            var statistics = employee.GetStatistics();
            var result = Math.Round(statistics.Average);

            // assert
            Assert.AreEqual(5, result);
        }
        [Test]
        public void AddScoreWithFloatTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(5);
            employee.AddScore(4f);
            employee.AddScore(3);
            employee.AddScore(7);
            employee.AddScore(1);

            // act
            var statistics = employee.GetStatistics();
            var result = Math.Round(statistics.Average);

            // assert
            Assert.AreEqual(4, result);
        }
        [Test]
        public void AddScoreWithDoubleTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(4d);
            employee.AddScore(8);
            employee.AddScore(1);

            // act
            var statistics = employee.GetStatistics();
            var result = Math.Round(statistics.Average);

            // assert
            Assert.AreEqual(5, result);
        }
    }
}