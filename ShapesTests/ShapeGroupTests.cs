using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class ShapeGroupTests
    {
        private Shape _a;
        private Shape _b;
        private ShapeGroup _group;

        [SetUp]
        public void Init()
        {
            _a = new StubShape();
            _b = new StubShape();
            _group = new ShapeGroup((a, b) => 0, 0);
        }

        [Test] [Category("Unit")]
        public void TestAdd()
        {
            _group.Add(_a);
            _group.Add(_b);
            Assert.That(_group.Contains(_a));
            Assert.That(_group.Contains(_b));
            Assert.That(_group.Count() == 2);
        }

        [Test] [Category("Unit")]
        public void TestRemove()
        {
            _group.Add(_a);
            _group.Add(_b);
            _group.Remove(_a);
            Assert.That(_group.Contains(_b));
            Assert.That(_group.Count() == 1);
        }
    }
}
