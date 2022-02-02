using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(1, 3, 5, 9)]
        [InlineData(4, 4, 3, 11)]
        [InlineData(1, 1, 0, 2)]
        [InlineData(1, -1, 0, 0)]
        [InlineData(-1, -1, -12, -14)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var testing = new UnitTestMethods();
            //Act
            int actual = testing.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(16, 2, 14)]
        [InlineData(5, 3, 2)]
        [InlineData(4, 6, -2)]
        [InlineData(1, 1, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(-1, -1, 0)]
        [InlineData(0, 0, 0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var testing = new UnitTestMethods();
            //Act
            int actual = testing.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(16, 2, 32)]
        [InlineData(5, 3, 15)]
        [InlineData(4, 6, 24)]
        [InlineData(1, 1, 1)]
        [InlineData(1, -1, -1)]
        [InlineData(-1, -1, 1)]
        [InlineData(0, 0, 0)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var testing = new UnitTestMethods();
            //Act
            int actual = testing.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-16, 2, -8)]
        [InlineData(5, 1, 5)]
        [InlineData(12, 6, 2)]
        [InlineData(1, 1, 1)]
        [InlineData(1, 0, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(0, 0, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var testing = new UnitTestMethods();
            //Act
            int actual = testing.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnHey()
        {
            //Arrange
            var testing = new UnitTestMethods();
            // Act
            string actual = testing.ReturnHey();
            // Assert
            Assert.Equal("HEY!", actual);
        }

        [Fact]
        public void IsItALetter()
        {
            //Arrange
            var testing = new UnitTestMethods();
            string alph = "abcdefghijklmnopqrstuvwxyz";
            //Checking all in alph
            foreach (char letter in alph)
            {
                //Act
                bool lowercaseActual = testing.IsItALetter(letter);
                bool uppercaseActual = testing.IsItALetter(char.ToUpper(letter));

                // Assert
                Assert.True(lowercaseActual);
                Assert.True(uppercaseActual);
            }
            Assert.False(testing.IsItALetter('1'));
        }
    }
}
