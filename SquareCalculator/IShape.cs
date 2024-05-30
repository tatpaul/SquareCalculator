namespace SquareCalculator
{
    /// <summary>
    /// Фигура
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Рассчет площадь фигуры
        /// </summary>
        /// <returns></returns>
        double CalculateSquare();

        /// <summary>
        /// Проверка фигуры на валидность
        /// </summary>
        /// <returns></returns>
        bool IsValid();
    }
}
