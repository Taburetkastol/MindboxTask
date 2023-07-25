using MindboxTask;

namespace TestMindboxTask
{
    public class CircleTests
    {
        [Test]
        public void GetAreaByRadius()
        {
            var circle = new Circle();
            circle.Radius = 0;
            var area = circle.GetArea();
            Assert.That(area, Is.EqualTo(0));
            circle.Radius = double.MaxValue;
            area = circle.GetArea();
            Assert.That(area, Is.EqualTo(double.PositiveInfinity));
        }

        [Test]
        public void CatchNegativeRadiusException()
        {
            var circle = new Circle();
            Assert.Catch(() => { circle.Radius = -1; });
        }

        [Test]
        public void CreateCircleWithoutArguments()
        {
            var circle = new Circle();
            Assert.That(circle.Radius, Is.EqualTo(0));
        }

        [Test]
        public void CreateCircleWithArguments()
        {
            var circle = new Circle(5);
            Assert.That(circle.Radius, Is.EqualTo(5));
        }

        [Test]
        public void CallUnknownTypeMethod()
        {
            Shape shape;
            shape = new Circle(2);
            Assert.That(shape.GetArea(), Is.EqualTo(12.566370614359172));
            shape = new Triangle(3, 4, 5);
            Assert.That(shape.GetArea(), Is.EqualTo(6));
        }
    }
}