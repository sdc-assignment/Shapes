using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    class TestPerimeterCalculator
    {
        private PerimeterCalculator _calc;
        [SetUp]
        public void Init()
        {
            _calc = new PerimeterCalculator();
        }

        [Test] [Category("Unit")]
        public void TestWithRectangle()
        {
            var rec = new Rectangle(new Vector2D(1, 1), new Vector2D(2, 5));
            Assert.AreEqual(rec.ApplyCalculator(_calc), 14, 1E-6);
        }

        [Test] [Category("Unit")]
        public void TestWithCircle()
        {
            var circle = new Circle(2.5, new Vector2D(1, 1));
            Assert.AreEqual(circle.ApplyCalculator(_calc), 15.70796326, 1E-6);
        }
    }
}
