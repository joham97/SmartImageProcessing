using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SmartImageProcessing
{
    internal static class ImageConverter
    {
        public static Pixel[] ToPixelArray(Bitmap image)
        {
            if (image == null) throw new ArgumentNullException("image");

            int PixelWidth = 3;
            PixelFormat PixelFormat = PixelFormat.Format24bppRgb;

            BitmapData data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat);
            try
            {
                Pixel[] pixels = new Pixel[image.Width * image.Height];
                byte[] pixelData = new Byte[data.Stride];
                for (int y = 0; y < data.Height; y++)
                {
                    Marshal.Copy(data.Scan0 + (y * data.Stride), pixelData, 0, data.Stride);
                    for (int x = 0; x < data.Width; x++)
                    {
                        var r = pixelData[x * PixelWidth + 2];
                        var g = pixelData[x * PixelWidth + 1];
                        var b = pixelData[x * PixelWidth];
                        pixels[y * image.Width + x] = new Pixel(r, g, b);
                    }
                }
                return pixels;
            }
            finally
            {
                image.UnlockBits(data);
            }
        }

        public static Bitmap ToBitmap(PixelImage image)
        {
            if (image == null) throw new ArgumentNullException("image");

            Bitmap bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format24bppRgb);

            for (int i = 0; i < image.pixels.Length; i++)
            {
                bitmap.SetPixel(i % image.Width, i / image.Width,
                    Color.FromArgb(0, image.pixels[i].R, image.pixels[i].G, image.pixels[i].B));
            }

            return bitmap;
        }
    }
}