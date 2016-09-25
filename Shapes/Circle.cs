using System;
using System.Collections.Generic;

namespace Shapes
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : Shape
    {
        private double _radius;
        private Vector2D _center;

        /// <summary>
        /// Радиус круга.
        /// </summary>
        /// <exception cref="ArgumentException">При попытке задать отрицательное значение радиуса.</exception>
        public double Radius
        {
            get { return _radius; }
            set
            {
                if(value >= 0) _radius = value;
                else throw new ArgumentException();
            }
        }

        /// <summary>
        /// Координаты центра круга.
        /// </summary>
        public Vector2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        /// <param name="center">Координаты центра.</param>
        public Circle(double radius, Vector2D center)
        {
            Radius = radius;
            Center = center;
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
