using System.Linq;

namespace SmartImageProcessing
{
    internal static class ImageBlackAndWhite
    {

        public static void BackAndWhite(PixelImage image)
        {
            for (int i = 0; i < image.pixels.Length; i++)
            {
                if ((image.pixels[i].R + image.pixels[i].G + image.pixels[i].B) / 3 > 127)
                {
                    image.pixels[i].R = 255;
                    image.pixels[i].G = 255;
                    image.pixels[i].B = 255;
                }
                else {
                    image.pixels[i].R = 0;
                    image.pixels[i].G = 0;
                    image.pixels[i].B = 0;
                }
            }
        }

    }
}
