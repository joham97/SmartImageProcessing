using System.Drawing;

namespace SmartImageProcessing
{
    public class PixelImage
    {

        public Pixel[] pixels { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public PixelImage(Bitmap bitmap)
        {
            pixels = ImageConverter.ToPixelArray(bitmap);
            Width = bitmap.Width;
            Height = bitmap.Height;
        }

        public PixelImage(Pixel[] pixels, int Width, int Height)
        {
            this.pixels = pixels;
            this.Width = Width;
            this.Height = Height;
        }

        public void BlackAndWhite()
        {
            ImageBlackAndWhite.BackAndWhite(this);
        }

        public Bitmap GetAsBitmap()
        {
            return ImageConverter.ToBitmap(this);
        }

        private void SetImage(PixelImage newImage)
        {
            this.pixels = newImage.pixels;
            this.Width = newImage.Width;
            this.Height = newImage.Height;
        }

    }
}
