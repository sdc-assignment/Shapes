namespace Shapes
{
    /// <summary>
    /// Базовый класс калькулятора для вычисления меры фигур. Паттерн посетитель.
    /// </summary>
    public abstract class ShapeMeasureCalculator
    {
        /// <summary>
        /// Вычисление меры круга.
        /// </summary>
        /// <param name="circle">Круг, для которого вычисляется мера.</param>
        /// <returns>Значнеие меры.</returns>
        public abstract double Calculate(Circle circle);

        /// <summary>
        /// Вычисление меры прямоугольника.
        /// </summary>
        /// <param name="rectangle">Прямоугольник, для которого вычисляется мера.</param>
        /// <returns>Значнеие меры.</returns>
        public abstract double Calculate(Rectangle rectangle);

        /// <summary>
        /// Вычисление меры группы фигур.
        /// </summary>
        /// <param name="group">Группа фигур, для которой вычисляется мера.</param>
        /// <returns>Значнеие меры.</returns>
        public double Calculate(ShapeGroup group)
        {
            return group.ApplyCalculator(this);
        }
    }
}
