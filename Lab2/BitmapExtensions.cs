using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System;
namespace BinarizationImage
{
    public static class BitmapExtensions
    {
        private static int amountIntensity = 256;
        private static byte[] array = null;
        private static byte[] arrayHierarchy = null;
        public static Bitmap GrayscaleImage(this Bitmap sourceImage)
        {
            array = new byte[sourceImage.Width * sourceImage.Height];
            arrayHierarchy = new byte[sourceImage.Width * sourceImage.Height];
            int i = 0, j = 0;
            Bitmap grayScaleImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    var red = sourceImage.GetPixel(x, y).R;
                    var green = sourceImage.GetPixel(x, y).G;
                    var blue = sourceImage.GetPixel(x, y).B;
                    var grayColor = (int)(0.299 * red) + (int)(0.587 * green) + (int)(0.114 * blue);
                    array[i++] = (byte)grayColor;
                    arrayHierarchy[j++] = (byte)grayColor;
                    grayScaleImage.SetPixel(x, y, Color.FromArgb(grayColor, grayColor, grayColor));
                }
            return grayScaleImage;
        }
        public static Bitmap QuantizedImage(this Bitmap sourceImage, int levelQuant)
        {
            Bitmap quantImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            if (array == null) return null;
            int delta = amountIntensity / levelQuant;
            var arrayLevels = new int[delta];
            for (int i = 2; i < arrayLevels.Length; i++)
                arrayLevels[i] = arrayLevels[i - 1] + delta;
            List<Color> listColors = new List<Color>();
            var rnd = new Random();
            for (int i = 0; i < levelQuant; i++)
            {
                var red = i * 100 * rnd.Next(0, 50);
                var green = i * 80 * rnd.Next(0, 30);
                var blue = i * 90 * rnd.Next(0, 40);
                listColors.Add(Color.FromArgb((byte)red, (byte)green, (byte)blue));
            }
            int count = 0;
            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    quantImage.SetPixel(x, y, Color.FromArgb(array[count], array[count], array[count]));
                    for (int k = 1; k < arrayLevels.Length - 1; k++)
                        if (array[count] >= arrayLevels[k - 1] && array[count] < arrayLevels[k])
                            quantImage.SetPixel(x, y, listColors[k - 2]);
                    count++;
                }
            }

            return quantImage;
        }
        public static Bitmap BinarizationWithLimit(this Bitmap sourceImage, int limit, bool reverse)
        {
            Bitmap binaryImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            if (array == null) return null;
            int i = 0;
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color color;
                    if (!reverse) color = array[i++] >= limit ? Color.White : Color.Black;
                    else color = array[i++] >= limit ? Color.Black : Color.White;
                    binaryImage.SetPixel(x, y, color);
                }
            return binaryImage;
        }
        public static Bitmap BinarizationWithRange(this Bitmap sourceImage, int fromLimit, int toLimit, bool reverse)
        {
            Bitmap binaryImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            if (array == null) return null;
            int i = 0;
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color color = Color.Black;
                    if (fromLimit < array[i] && array[i] <= toLimit) color = !reverse ? Color.White : Color.Black;
                    else if (array[i] <= fromLimit || array[i] > toLimit) color = !reverse ? Color.Black : Color.White;
                    i++;
                    binaryImage.SetPixel(x, y, color);
                }
            return binaryImage;
        }
        public static Bitmap BinarizationGlobalMethodOtsu(this Bitmap sourceImage, bool reverse, ref int thresh)
        {
            if (array == null) return null;
            thresh = ThresholdOtsu(array);
            return sourceImage.BinarizationWithLimit(thresh, reverse);
        }
        public static Bitmap BinarizationLocalMethodOtsu(this Bitmap sourceImage, bool reverse, int countParts)
        {
            int temp = 1;
            if (array == null) return null;
            if (countParts == 1) return sourceImage.BinarizationGlobalMethodOtsu(reverse, ref temp);
            Bitmap binaryImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            int heightBlock = sourceImage.Height / 2;
            int widthBlock = sourceImage.Width / (countParts / 2);


            int indexBeginHeight = 0, indexBeginWidth = 0;
            int indexEndHeight = 0, indexEndWidth = 0;

            for (int part = 0; part < countParts; part++)
            {
                if (part <= countParts / 2 - 1)
                {
                    indexBeginHeight = 0;
                    indexEndHeight = heightBlock;
                    indexEndWidth += widthBlock;
                }
                else if (part == countParts / 2)
                {
                    indexBeginHeight = heightBlock;
                    indexEndHeight += heightBlock;
                    indexBeginWidth = 0;
                    indexEndWidth = widthBlock;
                }
                else
                {
                    indexBeginWidth += widthBlock;
                    indexEndWidth += widthBlock;
                }
                while (indexEndWidth > sourceImage.Width) indexEndWidth--;
                while (indexEndHeight > sourceImage.Height) indexEndHeight--;

                int blockSize = heightBlock * widthBlock;
                byte[] imageArray = new byte[blockSize];
                int k = 0;
                for (int i = indexBeginHeight; i < indexEndHeight; i++)
                    for (int j = indexBeginWidth; j < indexEndWidth; j++)
                    {
                        var index = i * sourceImage.Width + j;
                        imageArray[k++] = array[index];
                    }
                var thresh = ThresholdOtsu(imageArray);
                int indexPixel = 0;
                for (int y = indexBeginHeight; y < indexEndHeight; y++)
                {
                    for (int x = indexBeginWidth; x < indexEndWidth; x++)
                    {
                        Color color;
                        if (!reverse) color = imageArray[indexPixel++] >= thresh ? Color.White : Color.Black;
                        else color = imageArray[indexPixel++] >= thresh ? Color.Black : Color.White;
                        binaryImage.SetPixel(x, y, color);
                    }
                }
                if (part <= countParts / 2 - 1) indexBeginWidth += widthBlock;
            }
            return binaryImage;
        }
        private static double[] GetIntensityMap(int[] hist)
        {
            double[] intensityMap = new double[256];
            
            for (int i = 0; i < hist.Length; i++)
                intensityMap[i] = 1.0 * hist[i] / array.Length;
            return intensityMap;
        }
        public static Bitmap BinarizationHierarchyMethodOtsu(this Bitmap sourceImage, int iterations, bool reverse)
        {   
            Bitmap binaryImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            List<int> listThresh = new List<int>();
            
            var intensity = GetIntensityMap(GetHistogram(array));
            RecMethodOtsu(intensity, listThresh, iterations);
            listThresh = listThresh.OrderBy(x => x).ToList();            
            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    var pixelSrc = sourceImage.GetPixel(x, y);
                    var oldColor = (pixelSrc.R + pixelSrc.G + pixelSrc.G) / 3;
                    var temp = listThresh.FindIndex(c => c > oldColor);
                    var color = temp % 2 == 0 ? Color.Black : Color.White;
                    binaryImage.SetPixel(x, y, color);
                }
            }
            return binaryImage;
        }
        private static int ThresholdOtsu(byte[] arrayImage)
        {
            var allPixelCount = arrayImage.Length;
            var hist = GetHistogram(arrayImage);
            var itensity = GetIntensitySum(arrayImage);
            int firstClassPixelCount = 0, firstClassIntensitySum = 0;
            int bestThresh = 0; double bestSigma = 0.0;
            for (int i = 0; i < amountIntensity - 1; i++)
            {
                firstClassPixelCount += hist[i];
                firstClassIntensitySum += i * hist[i];

                var firstClass = (double)firstClassPixelCount / (double)allPixelCount;
                var secondClass = 1.0 - firstClass;

                var firstClassMean = (double)firstClassIntensitySum / (double)firstClassPixelCount;
                var secondClassMean = (double)(itensity - firstClassIntensitySum) / (double)(allPixelCount - firstClassPixelCount);

                var delta = firstClassMean - secondClassMean;

                double sigma = firstClass * secondClass * delta * delta;
                if (sigma > bestSigma)
                {
                    bestSigma = sigma;
                    bestThresh = i;
                }
            }
            return bestThresh;
        }
        private static int[] GetHistogram(byte[] arrayImage)
        {
            var hist = new int[256];
            for (int i = 0; i < arrayImage.Length; i++)
                ++hist[arrayImage[i]];
            return hist;
        }
      
        private static int GetIntensitySum(byte[] arrayImage)
        {
            int sum = 0;
            for (int i = 0; i < arrayImage.Length; i++)
                sum += arrayImage[i];
            return sum;
        }
      
        private static void RecMethodOtsu(double[] intensity, List<int> listThresh, int iterations)
        {
            if (iterations == 0 || intensity.Length < 3) return;
            double[] disp = new double[intensity.Length];
            double q = intensity[0];
            double m1 = 0, m2 = 0;
            double nt = 0, mt = 0;
            for (int i = 0; i < intensity.Length; ++i)
            {
                nt += intensity[i];
                mt += intensity[i] * i;
            }
            mt /= nt;

            for (int i = 1; i < intensity.Length; ++i)
            {
                m1 = q * m1 + i * intensity[i];
                q += intensity[i];
                if (q == 0 || q == 1) continue;
                m1 /= q;
                m2 = (mt - q * m1) / (1 - q);
                disp[i] = Math.Sqrt(q * (1 - q) * (m1 - m2) * (m1 - m2));
            }

            var list = disp.ToList();
            var t = list.FindIndex(x => x == list.Max());
            listThresh.Add(t);

            double[] firstInterval = new double[t];
            for (int i = 0; i < t; ++i)
                firstInterval[i] = intensity[i];
            RecMethodOtsu(firstInterval, listThresh, iterations - 1);


            double[] secondInterval = new double[intensity.Length - t + 1];
            for (int i = t; i < intensity.Length; ++i)
                secondInterval[i - t] = intensity[i];
            RecMethodOtsu(secondInterval, listThresh, iterations - 1);
        }
    }
}
