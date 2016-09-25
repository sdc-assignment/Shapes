using System;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class RectangleTest
    {
        private Rectangle _r;

        [SetUp]
        public void Init()
        {
            _r = new Rectangle(new Vector2D(1, 1), new Vector2D(1, 1));
        }

        [Test] [Category("Unit")]
        public void TestNegativeScaleX()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(new Vector2D(1, 1),
                                                                 new Vector2D(-1, 1)));
        }

        [Test] [Category("Unit")]
        public void TestNegativeScaleY()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(new Vector2D(1, 1),
                                                                 new Vector2D(1, -1)));
        }

        [Test] [Category("Unit")]
        public void TestNegativeScaleYX()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(new Vector2D(1, 1),
                                                                 new Vector2D(-1, -1)));
        }

        [Test] [Category("Unit")]
        public void TestGetEnumerator()
        {
            Assert.IsEmpty(_r);
        }

        [Test] [Category("Unit")]
        public void TestAdd()
        {
            Assert.False(_r.Add(new StubShape()));
        }

        [Test] [Category("Unit")]
        public void TestRemove()
        {
            Assert.False(_r.Add(new StubShape()));
        }
    }
}