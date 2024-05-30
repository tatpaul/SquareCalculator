namespace SquareCalculator.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius) 
        {
            _radius = radius;
        }

        /// <inheritdoc/>
        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        /// <inheritdoc/>
        public bool IsValid()
        {
            return _radius > 0;
        }
    }
}
