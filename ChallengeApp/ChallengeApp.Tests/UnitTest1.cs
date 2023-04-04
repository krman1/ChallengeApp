namespace ChallengeApp.Tests
{
    public class Tests
    {
    
        [Test]
        public void GetStatisticsMaxTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(3);
            employee.AddScore(8);
            employee.AddScore(1);

            // act
            var statistics = employee.GetStatistics();
            var result = statistics.Max;

            // assert
            Assert.AreEqual(8, result);
        }
        [Test]
        public void ReGetStatisticsMinTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(3);
            employee.AddScore(8);
            employee.AddScore(1);

            // act
            var statistics = employee.GetStatistics();
            var result = statistics.Min;

            // assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void ReGetStatisticsAverageTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(3);
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