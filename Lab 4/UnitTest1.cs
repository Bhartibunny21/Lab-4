using NUnit.Framework;

namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle_EquilateralTriangle_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 70;
            int secondAngle = 90;
            int thirdAngle = 20;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle_SumOfAnglesIsNot180_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 50;
            int secondAngle = 90;
            int thirdAngle = 40;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void ValidTriangle_AllAnglesZero_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 0;
            int secondAngle = 10;
            int thirdAngle = 20;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        [Test]
        public void ValidTriangle1_EquilateralTriangle_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 20;
            int secondAngle = 140;
            int thirdAngle = 20;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle2_EquilateralTriangle_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 120;
            int secondAngle = 40;
            int thirdAngle = 20;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        // Add more test methods to cover additional scenarios
    }
}
