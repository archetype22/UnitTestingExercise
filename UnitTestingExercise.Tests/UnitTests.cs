using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3, 4, 5, 12)]
        [InlineData(3, 6, 9, 18)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange

            var instance = new Calculator();
            
            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = instance.Add(num1, num2, num3);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 5, 4)]//Add test data <-------
        [InlineData(10, 3, 7)]
        [InlineData(12, 4, 8)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var instance = new Calculator();

            //Act

            var actual = instance.Subtract(minuend, subtrhend);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        [InlineData(3, 3, 9)]
        [InlineData(5, 2, 10)]
        public void MultiplyTest(int factor1, int factor2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var instance = new Calculator();
            //Act
            var actual = instance.Multiply(factor1, factor2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 3, 3)]//Add test data <-------
        [InlineData(8, 4, 2)]
        [InlineData(10, 2, 5)]
        public void DivideTest(int dividend, int divisor, int expected)
        {
            //Arrange
            var instance = new Calculator();
            //Act
            var actual = instance.Divide(dividend, divisor);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
