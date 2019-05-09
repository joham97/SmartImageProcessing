using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace SmartImageProcessing.Tests
{
    [TestClass]
    public class PixelImageTests
    {
        [TestMethod]
        public void Constructor()
        {
            // Arrange
            Image image = Image.FromFile("image.jpg");

            // Act
            PixelImage pixelImage = new PixelImage(new Bitmap(image));

            // Assert
            Assert.IsNotNull(pixelImage.pixels);
            foreach (Pixel pixel in pixelImage.pixels)
            {
                if (pixel == null)
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void BlackAndWhite()
        {
            // Arrange
            Image image = Image.FromFile("image.jpg");
            PixelImage pixelImage = new PixelImage(new Bitmap(image));

            // Act
            pixelImage.BlackAndWhite();

            // Assert
            Assert.IsNotNull(pixelImage.pixels);
            pixelImage.GetAsBitmap().Save("image.png", ImageFormat.Png);

        }

        [TestMethod]
        public void ArrayTo2DAndReverse()
        {
            int width = 3;
            int height = 4;
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[,] array2D = new int[height, width];

            for (int i = 0; i < (width * height); i++)
            {
                array2D[i / width, i % width] = array[i];
            }

            int[] newArray = new int[12];
            for (int i = 0; i < (width * height); i++)
            {
                newArray[i] = array2D[i / width, i % width];
            }

            for (int i = 0; i < (width * height); i++)
            {
                Assert.AreEqual(array[i], newArray[i]);
            }
        }
    }
}