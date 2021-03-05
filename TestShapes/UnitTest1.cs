using NUnit.Framework;
using Shapes;
using System.Numerics;

namespace TestShapes
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Category("Circle")]
        public void CircleCircumference() =>
            Assert.AreEqual(6.0f * System.MathF.PI, new Circle(Vector2.Zero, 3.0f).Circumference);

        [Test, Category("Circle")]
        public void CircleArea() =>
            Assert.AreEqual(3.0f * 3.0f * System.MathF.PI, new Circle(Vector2.Zero, 3.0f).Area);
    }
}