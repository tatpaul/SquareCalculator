using SquareCalculator.Shapes;
using Xunit;

namespace SquareCalculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void InvalidTriangles()
        {
            var firstBadTriangle = new Triangle(1, 2, 4);
            var secondBadTriangle = new Triangle(0, -1, 1);

            Assert.False(firstBadTriangle.IsValid());
            Assert.False(secondBadTriangle.IsValid());
        }

        [Fact]
        public void ValidTriangle()
        {
            var validTriagle = new Triangle(2, 5, 6);

            Assert.True(validTriagle.IsValid());
        }

        [Fact]
        public void RightTriangle()
        {
            var rightTriagle = new Triangle(3, 4, 5);

            Assert.True(rightTriagle.IsRight());
        }

        [Fact]
        public void TriangleCalculateSquare()
        {
            var rightTriagle = new Triangle(3, 4, 5);

            var calcullatedSquare = rightTriagle.CalculateSquare();
            double assertedSquare = 6;

            Assert.Equal(assertedSquare, calcullatedSquare);
        }
    }
}
