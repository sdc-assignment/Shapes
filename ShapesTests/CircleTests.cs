using System;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class CircleTests
    {
        private Circle _c;

        [SetUp]
        public void Init()
        {
            _c = new Circle(1, new Vector2D(1, 1));
        }

        [Test] [Category("Unit")]
        public void TestNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1, new Vector2D(1, 1)));
        }

        [Test] [Category("Unit")]
        public void TestGetEnumerator()
        {
            Assert.IsEmpty(_c);
        }

        [Test] [Category("Unit")]
        public void TestAdd()
        {
            Assert.False(_c.Add(new StubShape()));
        }

        [Test] [Category("Unit")]
        public void TestRemove()
        {
            Assert.False(_c.Remove(new StubShape()));
        }
    }
}
