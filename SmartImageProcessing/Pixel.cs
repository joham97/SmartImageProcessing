namespace SmartImageProcessing
{
    public class Pixel
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public Pixel() : this(0, 0, 0)
        {
        }

        public Pixel(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public override string ToString()
        {
            return $"R: {R}; G: {G}; B: {B};";
        }

        public int RGB()
        {
            return (R << 16) + (G << 8) + B;
        }
    }
}