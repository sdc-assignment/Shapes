using System;
using System.Collections.Generic;

namespace Shapes
{
    /// <summary>
    /// Класс группы фигур. Паттерн компоновщик.
    /// </summary>
    public class ShapeGroup : Shape
    {
        private readonly HashSet<Shape> _children;
        /// <summary>
        /// Оператор для свёртки меры дочерних фигур.
        /// </summary>
        public Func<double, double, double> GroupOperator { get; set; }

        /// <summary>
        /// Начальное значение для свёртки меры дочерних фигур.
        /// </summary>
        public double Seed { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="groupOperator">Оператор для свёртки меры дочерних фигур.</param>
        /// <param name="seed">Начальное значение для свёртки меры дочерних фигур.</param>
        public ShapeGroup(Func<double, double, double> groupOperator, double seed)
        {
            _children = new HashSet<Shape>();
            GroupOperator = groupOperator;
            Seed = seed;
        }

        /// <summary>
        /// Использует переданный калькулятор для вычисления меры дочерних фигур.
        /// Выполняет свёртку полученных значений и <see cref="ShapeGroup.Seed"/> оператором <see cref="ShapeGroup.GroupOperator"/>.
        /// Паттерн посетитель.
        /// </summary>
        /// <param name="calculator">Калькулятор, используемый для вычисления.</param>
        /// <returns>Значение меры.</returns>
        public override double ApplyCalculator(ShapeMeasureCalculator calculator)
        {
            double sum = Seed;
            foreach (var shape in this)
                sum = GroupOperator(sum, shape.ApplyCalculator(calculator));
            return sum;
        }

        /// <summary>
        /// Добавление дочерней фигуры.
        /// </summary>
        /// <param name="shapeToAdd">Фигура для добавления в иерархию.</param>
        /// <returns>
        /// Возвращает <see langword="true"/>, если удалось добавить фигуру и <see langword="false"/> в противном случае.
        /// </returns>
        public override bool Add(Shape shapeToAdd)
        {
            return _children.Add(shapeToAdd);
        }

        /// <summary>
        /// Удаление дочерней фигуры.
        /// </summary>
        /// <param name="shapeToRemove">Фигура, которую требуется удалить.</param>
        /// <returns>
        /// Возвращает <see langword="true"/>, если удалось удалить фигуру и <see langword="false"/> в противном случае.
        /// </returns>
        public override bool Remove(Shape shapeToRemove)
        {
            return _children.Remove(shapeToRemove);
        }

        /// <summary>
        /// Возвращает итератор для перебора дочерних фигур.
        /// </summary>
        /// <returns>Итератор для перебора дочерних фигур.</returns>
        public override IEnumerator<Shape> GetEnumerator()
        {
            return _children.GetEnumerator();
        }
    }
}