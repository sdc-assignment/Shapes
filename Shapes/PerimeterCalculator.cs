using System;

namespace Shapes
{
    /// <summary>
    /// Калькулятор для вычисления периметра. Паттерн посетитель.
    /// </summary>
    public class PerimeterCalculator : ShapeMeasureCalculator
    {
        /// <summary>
        /// Вычисление длины окружности.
        /// </summary>
        /// <param name="circle">Круг, для которого вычисляется длина окружности.</param>
        /// <returns>Значнеие длины окружности.</returns>
        public override double Calculate(Circle circle)
        {
            return 2 * Math.PI * circle.Radius;
        }

        /// <summary>
        /// Вычисление периметра прямоугольника.
        /// </summary>
        /// <param name="rectangle">Прямоугольник, для которого вычисляется периметр.</param>
        /// <returns>Значнеие периметра.</returns>
        public override double Calculate(Rectangle rectangle)
        {
            return 2 * (rectangle.Size.Y + rectangle.Size.X);
        }
    }
}
