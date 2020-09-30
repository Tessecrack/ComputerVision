using System.Drawing;
using System;
using System.Linq;

namespace ColorCorrectionWinForms
{
    public class LuminanceConversions
    {
        public static Bitmap GetGrayWorld(Bitmap sourceImage) // серый мир
        {
            Bitmap grayWorld = new Bitmap(sourceImage.Width, sourceImage.Height);
            int redSumChannel = 0;
            int greenSumChannel = 0;
            int blueSumChannel = 0;
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    var color = sourceImage.GetPixel(x, y);
                    redSumChannel += color.R;
                    greenSumChannel += color.G;
                    blueSumChannel += color.B;
                }
            redSumChannel /= (sourceImage.Width * sourceImage.Height);
            greenSumChannel /= (sourceImage.Width * sourceImage.Height);
            blueSumChannel /= (sourceImage.Width * sourceImage.Height);

            int average = (redSumChannel + greenSumChannel + blueSumChannel) / 3;

            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    var sourceColor = sourceImage.GetPixel(x, y);
                    var red = sourceColor.R * (average / redSumChannel);
                    var green = sourceColor.G * (average / greenSumChannel);
                    var blue = sourceColor.B * (average / blueSumChannel);
                    var newColor = Color.FromArgb(red, green, blue);
                    grayWorld.SetPixel(x, y, newColor);
                }
            return grayWorld;
        }
        public static Bitmap GetNegative(Bitmap sourceImage) // негатив
        {
            Bitmap negativeImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    var color = sourceImage.GetPixel(x, y);
                    byte red = (byte)(255 - color.R);
                    byte green = (byte)(255 - color.G);
                    byte blue = (byte)(255 - color.B);
                    var newColor = Color.FromArgb(red, green, blue);
                    negativeImage.SetPixel(x, y, newColor);
                }
            return negativeImage;
        }
        public static Bitmap GetLogarithmImage(Bitmap sourceImage, int baseLog, int coef) //логарифм
        {
            Bitmap logImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    var color = sourceImage.GetPixel(x, y);
                    var red = coef * Math.Log(1 + color.R, baseLog);
                    var green = coef * Math.Log(1 + color.G, baseLog);
                    var blue = coef * Math.Log(1 + color.B, baseLog);
                    var newColor = Color.FromArgb((int)red, (int)green, (int)blue);
                    logImage.SetPixel(x, y, newColor);
                }
            return logImage;
        }
        public static Bitmap GetPowerImage(Bitmap sourceImage, double power, double coef) //степень
        {
            Bitmap powerImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    var color = sourceImage.GetPixel(x, y);
                    var red = coef * Math.Pow(color.R, power);
                    var green = coef * Math.Pow(color.G, power);
                    var blue = coef * Math.Pow(color.B, power);
                    Cut(ref red, ref green, ref blue);
                    var newColor = Color.FromArgb((int)red, (int)green, (int)blue);
                    powerImage.SetPixel(x, y, newColor);
                }
            return powerImage;
        }
        public static Bitmap GetGrayScaleImage(Bitmap sourceImage) //полутоновное изображение
        {
            Bitmap grayScaleImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    double redChannel = sourceImage.GetPixel(x, y).R;
                    double greenChannel = sourceImage.GetPixel(x, y).G;
                    double blueChannel = sourceImage.GetPixel(x, y).B;
                    var grayScaleColorValue = (int)(0.299 * redChannel) + (int)(0.587 * greenChannel) + (int)(0.114 * blueChannel);
                    var newColor = Color.FromArgb(grayScaleColorValue, grayScaleColorValue, grayScaleColorValue);
                    grayScaleImage.SetPixel(x, y, newColor);
                }
            return grayScaleImage;
        }
        public static Bitmap GetCorrectionImageBasedColor(Bitmap sourceImage, Color destination, Color source)
        {
            Bitmap correctionImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    var currentColor = sourceImage.GetPixel(x, y);
                    var redChannel = (double)(currentColor.R * (destination.R / (source.R+1)));
                    var greenChannel = (double)(currentColor.G * (destination.G / (source.G+1)));
                    var blueChannel = (double)(currentColor.B * (destination.B / (source.B + 1)));
                    Cut(ref redChannel, ref greenChannel, ref blueChannel);
                    Color newColor = Color.FromArgb((int)redChannel, (int)greenChannel, (int)blueChannel);
                    correctionImage.SetPixel(x, y, newColor);
                }
            return correctionImage;
        }
        public static Bitmap GetNormalizationImage(Bitmap grayImage)
        {
            Bitmap normImage = new Bitmap(grayImage.Width, grayImage.Height);
            int max = 0, min = 0;
            for (int y = 0; y < grayImage.Height; y++)
            {
                for (int x = 0; x < grayImage.Width; x++)
                {
                    var pixel = grayImage.GetPixel(x, y).R;
                    if (pixel > max) max = pixel;
                    if (pixel < min) min = pixel;
                }
            }
            for (int y = 0; y < grayImage.Height; y++)
            {
                for (int x = 0; x < grayImage.Width; x++)
                {
                    var currentColor = grayImage.GetPixel(x, y);
                    var channelR = ((currentColor.R - min) * 255.0 / (max - min));
                    var channelG = ((currentColor.G - min) * 255.0 / (max - min));
                    var channelB = ((currentColor.B - min) * 255.0 / (max - min));
                    var newColor = Color.FromArgb((int)channelR, (int)channelG, (int)channelB);
                    normImage.SetPixel(x, y, newColor);
                }
            }
            return normImage;
        }
        public static Bitmap GetEqualizationImage(Bitmap grayImage)
        {
            Bitmap equalizationImage = new Bitmap(grayImage.Width, grayImage.Height);
            double[] hist = new double[256];

            for (int y = 0; y < grayImage.Height-1; y++)
                for (int x = 0; x < grayImage.Width-1; x++)
                    hist[grayImage.GetPixel(x, y).R]++;

            for (int i = 0; i < hist.Length; i++)
                hist[i] = hist[i] / (256);

            for (int i = 1; i < hist.Length; i++)
                hist[i] = hist[i - 1] + hist[i];

            var max = hist.Max();
            for (int i = 0; i < hist.Length; i++)
                hist[i] = 250 * hist[i] / max;

            for (int y = 0; y < grayImage.Height - 1; y++) 
                for (int x = 0; x < grayImage.Width - 1; x++)
                {
                    var color = (int)Math.Round(hist[grayImage.GetPixel(x, y).R]);
                    if (color > 255) color = 255;
                    equalizationImage.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            return equalizationImage;
        }
        public static Bitmap GetAntiLogarithm(Bitmap sourceImage, double baseLog, double coef)
        {
            Bitmap antiImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    var color = sourceImage.GetPixel(x, y);
                    var redChannel   = Math.Pow(baseLog, (double)(color.R / coef));
                    var greenChannel = Math.Pow(baseLog, (double)(color.G / coef));
                    var blueChannel  = Math.Pow(baseLog, (double)(color.B / coef));
                    Cut(ref redChannel, ref greenChannel, ref blueChannel);
                    antiImage.SetPixel(x, y, Color.FromArgb((int)redChannel, (int)greenChannel, (int)blueChannel));
                }
            return antiImage;
        }
        public static Bitmap GetAntiPower(Bitmap sourceImage, double power, double coef)
        {
            Bitmap antiImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    var color = sourceImage.GetPixel(x, y);
                    var redChannel   = Math.Pow(color.R / coef, 1 / power);
                    var greenChannel = Math.Pow(color.G / coef, 1 / power);
                    var blueChannel  = Math.Pow(color.B / coef, 1 / power);
                    Cut(ref redChannel, ref greenChannel, ref blueChannel);
                    antiImage.SetPixel(x, y, Color.FromArgb((int)redChannel, (int)greenChannel, (int)blueChannel));
                }
            return antiImage;
        }
        private static void Cut(ref double red, ref double green, ref double blue)
        {
            if (red > 255)      red = 255;
            else if (red < 0)   red = 0;
            if (green > 255)    green = 255;
            else if (green < 0) green = 0;
            if (blue > 255)     blue = 255;
            else if (blue < 0)  blue = 0;
        }
    }
}
