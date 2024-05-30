namespace SquareCalculator.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IShape
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        /// <inheritdoc />
        public double CalculateSquare()
        {
            double halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSide) *
                (halfPerimeter - _secondSide) * (halfPerimeter - _thirdSide));
        }

        /// <inheritdoc />
        public bool IsValid()
        {
            bool noNegativeSide = _firstSide > 0 && 
                                  _secondSide > 0 && 
                                  _thirdSide > 0;

            bool noSideBiggerThenOthersSum = (_firstSide + _secondSide > _thirdSide) &&
                                             (_secondSide + _thirdSide > _firstSide) &&
                                             (_firstSide + _thirdSide > _secondSide);

            return noNegativeSide && noSideBiggerThenOthersSum;
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        /// <returns><c>true</c> - если треугольник прямоугольный, <c>false</c> - если иной</returns>
        public bool IsRight()
        {
            return (Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2) == Math.Pow(_thirdSide, 2)) ||
                (Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2) == Math.Pow(_firstSide, 2)) ||
                (Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2) == Math.Pow(_secondSide, 2));
        }
    }
}
