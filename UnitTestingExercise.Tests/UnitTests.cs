using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var myCalculator = new Calculator();



            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = myCalculator.Add(2,3,5);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var myCalculator = new Calculator();
            //Act
             int actual = myCalculator.Sub(10, 5);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(7,6,42)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var myCalculator = new Calculator();
            //Act
             int actual = myCalculator.Multi(7,6);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(24,12,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var myCalculater = new Calculator();

            //Act
            int actual = myCalculater.div(24,12);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
