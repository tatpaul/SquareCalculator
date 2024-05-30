namespace SquareCalculator
{
    public static class Calculator
    {
        public static double CalculateSquare(IShape shape)
        {
            if (shape == null)
                throw new ArgumentNullException(nameof(shape));

            if (!shape.IsValid())
                throw new ArgumentException("Невалидная фигура");

            return shape.CalculateSquare();
        }
    }
}
