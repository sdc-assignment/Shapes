using System;
using System.Collections.Generic;

namespace Shapes
{
    /// <summary>
    /// Прямоугольник.
    /// </summary>
    public class Rectangle : Shape
    {
        private Vector2D _leftTop;
        private Vector2D _size;

        /// <summary>
        /// Верхний левый угол прямоугольника.
        /// </summary>
        public Vector2D LeftTop
        {
            get { return _leftTop; }
            set { _leftTop = value; }
        }

        /// <summary>
        /// Ширина и высота прямоугольника.
        /// </summary>
        /// <exception cref="ArgumentException">При попытке задать отрицательную ширину или высоту.</exception>
        public Vector2D Size
        {
            get { return _size; }
            set
            {
                if (value.X >= 0 && value.Y >= 0) _size = value;
                else throw new ArgumentException();
            }
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="leftTop">Координаты верхнего левого угла.</param>
        /// <param name="size">Размер.</param>
        public Rectangle(Vector2D leftTop, Vector2D size)
        {
            Size = size;
            LeftTop = leftTop;
        }


        /// <summary>
        /// Использование вычислителя меры. Паттерн посетитель.
        /// </summary>
        /// <param name="calculator">Калькулятор, используемый для вычисления.</param>
        /// <returns>Значение меры.</returns>
        public override double ApplyCalculator(ShapeMeasureCalculator calculator)
        {
            return calculator.Calculate(this);
        }

        /// <summary>
        /// Добавление дочерней фигуры.
        /// </summary>
        /// <param name="shapeToAdd">Фигура для добавления в иерархию.</param>
        /// <returns>
        /// Всегда возвращает <see langword="false"/>, так как не может иметь потомков.
        /// </returns>
        public override bool Add(Shape shapeToAdd)
        {
            return false;
        }

        /// <summary>
        /// Удаление дочерней фигуры.
        /// </summary>
        /// <param name="shapeToRemove">Фигура, которую требуется удалить.</param>
        /// <returns>
        /// Всегда возвращает <see langword="false"/>, так как не может иметь потомков.
        /// </returns>
        public override bool Remove(Shape shapeToRemove)
        {
            return false;
        }


        /// <summary>
        /// Возвращает итератор для перебора дочерних фигур.
        /// </summary>
        /// <returns>Возвращает пустой итератор, так как не может иметь потомков.</returns>
        public override IEnumerator<Shape> GetEnumerator()
        {
            yield break;
        }
    }
}
