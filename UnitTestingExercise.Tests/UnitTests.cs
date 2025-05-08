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
            // create a Calculator object
            var calculator = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData(9, 4, 5)]
        [InlineData(5, 10, -5)] //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

         [Theory]
         [InlineData(4, 4, 16)]
         [InlineData(2, -3, -6)]//Add test data <-------
         public void MultiplyTest(int multi1, int multi2, int expected)
         {
             //Start Step 7 here:

             //Arrange
             var calculator = new Calculator();

             //Act
             var actual = calculator.Multiply(multi1, multi2);

             //Assert
             Assert.Equal(expected, actual);

         }

         [Theory]
         [InlineData(10, 5, 2)]
         [InlineData(12, 5, 2.4)]//Add test data <-------
         public void DivideTest(int num1, int num2, int expected)
         {
             //Arrange
             var calculator = new Calculator();

             //Act
             var actual = calculator.Divide(num1, num2);

             //Assert
             Assert.Equal(expected, actual);

         }

     }
    }
