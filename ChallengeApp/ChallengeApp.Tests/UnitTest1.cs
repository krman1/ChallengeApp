namespace ChallengeApp.Tests
{
    public class Tests
    {
    
        [Test]
        public void GetStatisticsInEmployeeFileTest()
        {
            // arrange
            var employeeFile = new EmployeeInFile("£ukasz", "Kowalski"); ;
            employeeFile.AddScore(5f);
            employeeFile.AddScore("15");
            employeeFile.AddScore('d');

            // act
            var statistics = employeeFile.GetStatistics();
            var result = Math.Round(statistics.Average);
            var result1 = (statistics.Min);
            var result2 = (statistics.Max);
            var result3 = (statistics.AverageLetter);

            // assert
            Assert.AreEqual(20, result);
            Assert.AreEqual(5, result1);
            Assert.AreEqual(40, result2);
            Assert.AreEqual('D', result3);


        }

    }
}