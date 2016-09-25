using System;

namespace Shapes
{
    /// <summary>
    /// Калькулятор для вычисления площади. Паттерн посетитель.
    /// </summary>
    public class AreaCalculator : ShapeMeasureCalculator
    {
        /// <summary>
        /// Вычисление площади круга.
        /// </summary>
        /// <param name="circle">Круг, для которого вычисляется площадь.</param>
        /// <returns>Значение площади.</returns>
        public override double Calculate(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        /// <summary>
        /// Вычисление площади прямоугольника.
        /// </summary>
        /// <param name="rectangle">Прямоугольник, для которого вычисляется площадь.</param>
        /// <returns>Значнеие площади.</returns>
        public override double Calculate(Rectangle rectangle)
        {
            return rectangle.Size.Y * rectangle.Size.X;
        }
    }
}
