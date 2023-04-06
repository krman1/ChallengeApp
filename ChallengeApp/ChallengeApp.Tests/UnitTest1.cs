namespace ChallengeApp.Tests
{
    public class Tests
    {
    
        [Test]
        public void AddGetStatisticsWithForEachTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(3);
            employee.AddScore(8);
            employee.AddScore(2);

            // act
            var statistics = employee.GetStatisticsWithForEach();
            var result = Math.Round(statistics.Average);
            var result1 = Math.Round(statistics.Min);
            var result2 = Math.Round(statistics.Max);

            // assert
            Assert.AreEqual(5, result);
            Assert.AreEqual(2, result1);
            Assert.AreEqual(8, result2);
        }
        [Test]
        public void AddGetStatisticsWithForTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(3);
            employee.AddScore(8);
            employee.AddScore(2);

            // act
            var statistics = employee.GetStatisticsWithFor();
            var result = Math.Round(statistics.Average);
            var result1 = Math.Round(statistics.Min);
            var result2 = Math.Round(statistics.Max);

            // assert
            Assert.AreEqual(5, result);
            Assert.AreEqual(2, result1);
            Assert.AreEqual(8, result2);
        }
        [Test]
        public void AddGetStatisticsWithDoWileTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(3);
            employee.AddScore(8);
            employee.AddScore(2);

            // act
            var statistics = employee.GetStatisticsWithDoWhile();
            var result = Math.Round(statistics.Average);
            var result1 = Math.Round(statistics.Min);
            var result2 = Math.Round(statistics.Max);

            // assert
            Assert.AreEqual(5, result);
            Assert.AreEqual(2, result1);
            Assert.AreEqual(8, result2);
        }
        [Test]
        public void AddGetStatisticsWithWhileTest()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(3);
            employee.AddScore(8);
            employee.AddScore(2);

            // act
            var statistics = employee.GetStatisticsWithWhile();
            var result = Math.Round(statistics.Average);
            var result1 = Math.Round(statistics.Min);
            var result2 = Math.Round(statistics.Max);

            // assert
            Assert.AreEqual(5, result);
            Assert.AreEqual(2, result1);
            Assert.AreEqual(8, result2);
        }

    }
}