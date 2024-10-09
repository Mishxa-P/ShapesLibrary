using NUnit.Framework;
using ShapesLibrary;

namespace ShapesLibraryTests
{
    [TestFixture]
    public class ShapesTests
    {
        [Test]
        public void CircleArea_ValidRadius_CalculatesCorrectArea()
        {
            double radius = 5;
            Circle circle = new Circle(radius);

            double area = Shape.CalculateArea(circle);
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.That(area, Is.EqualTo(expectedArea).Within(1e-10), "Area calculation for Circle is incorrect.");
        }

        [Test]
        public void TriangleArea_ValidSides_CalculatesCorrectArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            double area = Shape.CalculateArea(triangle);
            double expectedArea = 6; // Площадь треугольника с основаниями 3 и 4
            Assert.That(area, Is.EqualTo(expectedArea).Within(1e-10), "Area calculation for Triangle is incorrect.");
        }

        [Test]
        public void Circle_InvalidRadius_ThrowsException()
        {
            double invalidRadius = -5;

            var ex = Assert.Throws<ArgumentException>(() => new Circle(invalidRadius));
            Assert.That(ex.Message, Is.EqualTo("Radius of circle must be greater than zero"));
        }

        [Test]
        public void Triangle_InvalidSides_ThrowsException()
        {
            double sideA = 1;
            double sideB = 2;
            double sideC = 3; 

            var ex = Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
            Assert.That(ex.Message, Is.EqualTo("Sides can`t form a triangle"));
        }

        [Test]
        public void Triangle_IsRightAngledTriangle_ValidSides_ReturnsTrue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRightTriangle = triangle.IsRightAngledTriangle();

            Assert.That(isRightTriangle, "Triangle should be a right triangle.");
        }

        [Test]
        public void Shape_CalculateArea_Null_ThrowsException()
        {
            Triangle testShape = null;

            var ex = Assert.Throws<ArgumentNullException>(() => Shape.CalculateArea(testShape));
            Assert.That(ex.Message, Is.EqualTo("Shape cant be null (Parameter 'shape')"));
        }
    }
}  
