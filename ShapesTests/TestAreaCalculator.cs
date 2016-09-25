using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    class TestAreaCalculator
    {
        private AreaCalculator _calc;
        [SetUp]
        public void Init()
        {
            _calc = new AreaCalculator();
        }

        [Test] [Category("Unit")]
        public void TestWithRectangle()
        {
            var rec = new Rectangle(new Vector2D(1, 1), new Vector2D(2, 3));
            Assert.AreEqual(rec.ApplyCalculator(_calc), 6, 1E-6);
        }

        [Test] [Category("Unit")]
        public void TestWithCircle()
        {
            var circle = new Circle(2.5, new Vector2D(1, 1));
            Assert.AreEqual(circle.ApplyCalculator(_calc), 19.634954084, 1E-6);
        }
    }
}
