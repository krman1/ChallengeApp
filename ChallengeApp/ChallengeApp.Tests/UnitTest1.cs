namespace ChallengeApp.Tests
{
    public class Tests
    {
    
        [Test]
        public void ResultTestWithAllPozitiveRating()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak", 34);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(3);
            employee.AddScore(8);
            employee.AddScore(1);

            // act
            int result = employee.Result;

            // assert
            Assert.AreEqual(24, result);
        }
        [Test]
        public void ResultTestWithNegativeRating()
        {
            // arrange
            Employee employee = new Employee("Adam", "Nowak", 34);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(-3);
            employee.AddScore(8);
            employee.AddScore(1);

            // act
            int result = employee.Result;

            // assert
            Assert.AreEqual(18, result);
        }
    }
}