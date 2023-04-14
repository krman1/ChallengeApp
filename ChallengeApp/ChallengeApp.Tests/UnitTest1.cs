namespace ChallengeApp.Tests
{
    public class Tests
    {
    
        [Test]
        public void AddGetStatisticsForSupervizorTest()
        {
            // arrange
            var supervizor = new Supervizor("£ukasz", "Kowalski"); ;
            supervizor.AddScore("1");
            supervizor.AddScore("2");
            supervizor.AddScore("-3");
            supervizor.AddScore("4+");

            // act
            var statistics = supervizor.GetStatistics();
            var result = Math.Round(statistics.Average);
            var result1 = (statistics.Min);
            var result2 = (statistics.Max);

            // assert
            Assert.AreEqual(30, result);
            Assert.AreEqual(0, result1);
            Assert.AreEqual(65, result2);
        }

    }
}