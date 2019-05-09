using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmartImageProcessing.Tests
{
    [TestClass]
    public class PixelTests
    {
        [TestMethod]
        public void GetR()
        {
            // Arrange
            byte r = 128;

            // Act
            Pixel pixel = new Pixel(r, 0, 255);

            // Assert
            Assert.AreEqual(r, pixel.R);
        }

        [TestMethod]
        public void GetG()
        {
            // Arrange
            byte g = 128;

            // Act
            Pixel pixel = new Pixel(0, g, 255);

            // Assert
            Assert.AreEqual(g, pixel.G);
        }

        [TestMethod]
        public void GetB()
        {
            // Arrange
            byte b = 128;

            // Act
            Pixel pixel = new Pixel(0, 255, b);

            // Assert
            Assert.AreEqual(b, pixel.B);
        }

        [TestMethod]
        public void GetRGB()
        {
            // Arrange
            byte r = 128;
            byte g = 255;
            byte b = 100;

            // Act
            Pixel pixel = new Pixel(r, g, b);

            // Assert
            Assert.AreEqual(8453988, pixel.RGB());
        }

        [TestMethod]
        public void SetRGB()
        {
            // Arrange
            Pixel pixel = new Pixel();
            byte r = 128;
            byte g = 255;
            byte b = 100;

            // Act
            pixel.R = 128;
            pixel.G = 255;
            pixel.B = 100;

            // Assert
            Assert.AreEqual(r, pixel.R);
            Assert.AreEqual(g, pixel.G);
            Assert.AreEqual(b, pixel.B);
        }
    }
}