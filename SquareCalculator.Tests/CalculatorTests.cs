using SquareCalculator.Shapes;
using Xunit;

namespace SquareCalculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ThrowExceptionIfShapeIsNull()
        {
            IShape shape = null;
            Action act = () => Calculator.CalculateSquare(shape);
            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void ThrowExceptionIfShapeIsInvalid()
        {
            var badCircle = new Circle(0);
            var badTriangle = new Triangle(0, 1, 2);

            Action calcCircle = () => Calculator.CalculateSquare(badCircle);
            Action calcTriange = () => Calculator.CalculateSquare(badTriangle);

            Assert.Throws<ArgumentException>(calcCircle);
            Assert.Throws<ArgumentException>(calcTriange);
        }
    }
}
