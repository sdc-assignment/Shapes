namespace Shapes
{
    public struct Vector2D
    {
        /// <summary>
        /// X-координата вектора.
        /// </summary>
        public readonly double X;

        /// <summary>
        /// Y-координата вектора.
        /// </summary>
        public readonly double Y;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="x">x-координата вектора.</param>
        /// <param name="y">y-координата вектора.</param>
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает хеш-код.
        /// </summary>
        /// 
        /// <returns>
        /// 32-битный знаковый целочисленный хеш-код.
        /// </returns>
        public override int GetHashCode()
        {
            return unchecked(X.GetHashCode() + Y.GetHashCode());
        }

        /// <summary>
        /// Проверка на равенство другому Vector2D по значению.
        /// </summary>
        /// <param name="other">Вектор, равенство которому подлежит проверке.</param>
        /// <returns>
        /// Возвращает <see langword="true"/> если вектора равны и <see langword="false"/> в противном случае.
        /// </returns>
        public bool Equals(Vector2D other)
        {
            if(other.X == X && other.Y == Y) return true;
            return false;
        }

        /// <summary>
        /// Проверка на равенство экземпляру object.
        /// </summary>
        /// <param name="other">Объект, равенство которому подлежит проверке.</param>
        /// <returns>
        /// Возвращает <see langword="true"/> если вектор и объект равны и <see langword="false"/> в противном случае.
        /// </returns>
        public override bool Equals(object other)
        {
            if (other is Vector2D) return Equals((Vector2D)other);
            return false;
        }
    }
}
