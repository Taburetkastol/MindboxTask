using MindboxTask;

namespace TestMindboxTask
{
    public class TriangleTests
    {
        [Test]
        public void GetArea()
        {
            var triangle = new Triangle(0, 0, 0);
            var area = triangle.GetArea();
            Assert.That(area, Is.EqualTo(0));
            triangle.A = 1;
            triangle.B = 1;
            triangle.C = 1;
            area = triangle.GetArea();
            Assert.That(area, Is.EqualTo(0.4330127018922193));
        }

        [Test]
        public void CatchNegativeArgumentsException()
        {
            var triangle = new Triangle(0, 0, 0);
            Assert.Catch(() => { triangle.A = -1; });
            Assert.Catch(() => { triangle.B = -1; });
            Assert.Catch(() => { triangle.C = -1; });
        }

        [Test]
        public void CreateTriangleWithArguments()
        {
            var triangle = new Triangle(1, 2, 3);
            Assert.That(triangle.A, Is.EqualTo(1));
            Assert.That(triangle.B, Is.EqualTo(2));
            Assert.That(triangle.C, Is.EqualTo(3));
        }

        [Test]
        public void TestNotExistingTriangle()
        {
            Assert.Catch(() => { var triangle = new Triangle(1, 1, 10); });
        }

        [Test]
        public void TestGetAreaForNotExistingTriangle()
        {
            Assert.Catch(() => { new Triangle(1, 1, 10).GetArea(); });
        }
    }
}