using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Samples.Antlr4.Tests
{
    public class InvertedPolishCalculatorTests
    {
        public class Compute
        {
            [Fact]
            public void Can_Compute_Addition()
            {
                //Arrange
                var calculator = new InvertedPolishCalculator();
                var expectedResult = 3;
                //Act
                var result = calculator.Compute("1 2 +");
                //Assert
                Assert.Equal(expectedResult, result);
            }

            [Fact]
            public void Can_Compute_Substraction()
            {
                //Arrange
                var calculator = new InvertedPolishCalculator();
                var expectedResult = 1;
                //Act
                var result = calculator.Compute("2 1 -");
                //Assert
                Assert.Equal(expectedResult, result);
            }

            [Fact]
            public void Can_Compute_Multiplication()
            {
                //Arrange
                var calculator = new InvertedPolishCalculator();
                var expectedResult = 10;
                //Act
                var result = calculator.Compute("2 5 *");
                //Assert
                Assert.Equal(expectedResult, result);
            }

            [Fact]
            public void Can_Compute_Division()
            {
                //Arrange
                var calculator = new InvertedPolishCalculator();
                var expectedResult = 5;
                //Act
                var result = calculator.Compute("10 2 /");
                //Assert
                Assert.Equal(expectedResult, result);
            }


            [Fact]
            public void Can_compute_nested_additions()
            {
                //Arrange
                var calculator = new InvertedPolishCalculator();
                var expectedResult = 3;
                //Act
                var result = calculator.Compute("1 1 1 + +");
                //Assert
                Assert.Equal(expectedResult, result);
            }


            [Fact]
            public void Can_compute_Negative_numbers()
            {
                //Arrange
                var calculator = new InvertedPolishCalculator();
                var expectedResult = -2;
                //Act
                var result = calculator.Compute("-1 2 *");
                //Assert
                Assert.Equal(expectedResult, result);
            }


            [Fact]
            public void Can_compute_Negative_numbers_as_second_operande()
            {
                //Arrange
                var calculator = new InvertedPolishCalculator();
                var expectedResult = -2;
                //Act
                var result = calculator.Compute("1 -2 *");
                //Assert
                Assert.Equal(expectedResult, result);
            }

        }
    }
}
