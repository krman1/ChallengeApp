namespace ChallengeApp.Tests
{
    public class Tests
    {
    
        [Test]
        public void AddGetStatisticsWithDifferentDataTest()
        {   
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(54);
            employee.AddScore("5");
            employee.AddScore('A');
            employee.AddScore(83);
            employee.AddScore(2);

            // act
            var statistics = employee.GetStatistics();
            var result = Math.Round(statistics.Average);
            var result1 = (statistics.Min);
            var result2 = (statistics.Max);

            // assert
            Assert.AreEqual(49, result);
            Assert.AreEqual(2, result1);
            Assert.AreEqual(100, result2);
        }
        [Test]
        public void AverageLetterTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(54);
            employee.AddScore("5");
            employee.AddScore('A');
            employee.AddScore(83);
            employee.AddScore(2);

            // act
            var statistics = employee.GetStatistics();
            var result = (statistics.AverageLetter);

            // assert
            Assert.AreEqual('C', result);
        }

    }
}