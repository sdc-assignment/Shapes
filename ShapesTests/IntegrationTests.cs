using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    class IntegrationTests
    {
        #region vars
        private PerimeterCalculator _perimeterCalc;
        private AreaCalculator _areaCalc;
        private Shape _mulGroup;
        private Shape _sumGroup;
        private Shape _c1;
        private Shape _c2;
        private Shape _r1;
        private Shape _r2;
        #endregion

        [SetUp]
        public void Init()
        {
            _perimeterCalc = new PerimeterCalculator();
            _areaCalc = new AreaCalculator();
            _sumGroup = new ShapeGroup((a, b) => a + b, 0);
            _mulGroup = new ShapeGroup((a, b) => a * b, 1);
            _c1 = new Circle(1, new Vector2D(1, 1));
            _c2 = new Circle(2, new Vector2D(1, 1));
            _r1 = new Rectangle(new Vector2D(1, 1), new Vector2D(2, 3));
            _r2 = new Rectangle(new Vector2D(1, 1), new Vector2D(5, 1));
        }

        [Test] [Category("Integration")]
        public void IntegrationTest1()
        {
            _mulGroup.Add(_c1);
            _mulGroup.Add(_r1);
            _mulGroup.Add(_r2);
            _sumGroup.Add(_c2);
            _sumGroup.Add(_mulGroup);
            Assert.AreEqual(_sumGroup.ApplyCalculator(_perimeterCalc), 766.54860747, 1E-6);
        }

        [Test] [Category("Integration")]
        public void IntegrationTest2()
        {
            _mulGroup.Add(_c1);
            _sumGroup.Add(_r1);
            _sumGroup.Add(_r2);
            _sumGroup.Add(_c2);
            _sumGroup.Add(_mulGroup);
            Assert.AreEqual(_sumGroup.ApplyCalculator(_areaCalc), 26.707963267, 1E-6);
        }
    }
}
