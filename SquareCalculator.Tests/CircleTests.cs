using SquareCalculator.Shapes;
using Xunit;

namespace SquareCalculator.Tests
{
    public class CircleTests
    {
        [Fact]
        public void InvalidCircle()
        {
            var firstBadCircle = new Circle(0);
            var secondBadCircle = new Circle(-5);

            Assert.False(firstBadCircle.IsValid());
            Assert.False(secondBadCircle.IsValid());
        }

        [Fact]
        public void ValidCircle()
        {
            var validCircle = new Circle(2);

            Assert.True(validCircle.IsValid());
        }

        [Fact]
        public void CircleCalculateSquare()
        {
            var circle = new Circle(2);

            var calcullatedSquare = circle.CalculateSquare();
            double assertedSquare = Math.PI * 2 * 2;

            Assert.Equal(assertedSquare, calcullatedSquare);
        }
    }
}
