using System;
using System.Collections.Generic;
using Shapes;

namespace ShapesTests
{
    class StubShape : Shape
    {
        public override double ApplyCalculator(ShapeMeasureCalculator calculator)
        {
            throw new NotImplementedException();
        }

        public override bool Add(Shape shapeToAdd)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Shape shapeToRemove)
        {
            throw new NotImplementedException();
        }

        public override IEnumerator<Shape> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
