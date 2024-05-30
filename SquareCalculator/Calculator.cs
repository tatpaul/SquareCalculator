namespace SquareCalculator
{
    /// <summary>
    /// Класс для расчета
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Рассчет площади фигур
        /// </summary>
        /// <param name="shape">Фигура</param>
        /// <returns>Площадь фигуры</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
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
