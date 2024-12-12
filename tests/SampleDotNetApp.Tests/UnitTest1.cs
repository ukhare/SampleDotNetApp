using Xunit;

namespace SampleDotNetApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var expected = 5;
            var actual = 2 + 3;

            // Act & Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(2, 4, 6)]
        [InlineData(0, 0, 0)]
        public void Test2(int a, int b, int expected)
        {
            // Act
            var actual = a + b;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
