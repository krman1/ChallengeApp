
using Newtonsoft.Json.Linq;

namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        [Test]
        public void ComparisonReferenceTypes()
        {
            // arrange
            var employee1 = CreateEmployee("Marcin");
            var employee2 = CreateEmployee("Tomek");

            // act
           

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }
        [Test]
        public void ComparisonValueTypesInt()
        {
            // arrange
            int number1 = 2;
            int number2 = 2;

            // act
            

            // assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void ComparisonValueTypesFloat()
        {
            // arrange
            float number1 = 2.3f;
            float number2 = 2.3f;

            // act
            

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void ComparisonStrings()
        {
            // arrange
            String text1 = "kurs programowania";
            String text2 = "kurs programowania";

            // act


            // assert
            Assert.AreEqual(text1, text2);
        }
        private Employee CreateEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
