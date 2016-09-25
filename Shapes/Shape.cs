using System.Collections;
using System.Collections.Generic;

namespace Shapes
{
    /// <summary>
    /// Базовый класс фигуры. Паттерн компоновщик.
    /// </summary>
    public abstract class Shape: IEnumerable<Shape>
    {
        /// <summary>
        /// Использование вычислителя меры. Паттерн посетитель.
        /// </summary>
        /// <param name="calculator">Калькулятор, используемый для вычисления.</param>
        /// <returns>Значение меры.</returns>
        public abstract double ApplyCalculator(ShapeMeasureCalculator calculator);

        /// <summary>
        /// Добавление дочерней фигуры.
        /// </summary>
        /// <param name="shapeToAdd">Фигура для добавления в иерархию.</param>
        /// <returns>
        /// Возвращает <see langword="true"/>, если удалось добавить фигуру и <see langword="false"/> в противном случае.
        /// </returns>
        public abstract bool Add(Shape shapeToAdd);

        /// <summary>
        /// Удаление дочерней фигуры.
        /// </summary>
        /// <param name="shapeToRemove">Фигура, которую требуется удалить.</param>
        /// <returns>
        /// Возвращает <see langword="true"/>, если удалось удалить фигуру и <see langword="false"/> в противном случае.
        /// </returns>
        public abstract bool Remove(Shape shapeToRemove);

        /// <summary>
        /// Возвращает итератор для перебора дочерних фигур.
        /// </summary>
        /// <returns>Итератор для перебора дочерних фигур.</returns>
        public abstract IEnumerator<Shape> GetEnumerator(); 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
