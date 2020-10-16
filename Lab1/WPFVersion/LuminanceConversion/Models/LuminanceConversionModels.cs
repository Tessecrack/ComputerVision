using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LuminanceConversion.Models
{
    class LuminanceConversionModels
    {        
        public string Name { get; set; }
        public BitmapSource LoadImage { get; set; }
        public byte[] SourceImageArray { get; set; } //+
        public byte[] GrayscaleImageArray { get; set; } //+
        public byte[] GrayWorldImageArray { get; set; } //+
        public byte[] NegativeImageArray { get; set; } //+
        public byte[] ReferenceColorImageArray { get; set; } //- 
        public byte[] NormalizationImageArray { get; set; } //-
        public byte[] EqualizationImageArray { get; set; } //-

        public byte ReferenceColorR = 0;
        public byte ReferenceColorG = 0;
        public byte ReferenceColorB = 0;

        public byte SourceColorR = 0;
        public byte SourceColorG = 0;
        public byte SourceColorB = 0;

        public void ConvertSourceImageToPixelArray(BitmapSource loadImage)
        {
            if (loadImage.Format != PixelFormats.Bgra32)
                loadImage = new FormatConvertedBitmap(LoadImage, PixelFormats.Bgra32, null, 0);
            int height = loadImage.PixelHeight;
            int width =  loadImage.PixelWidth;
            SourceImageArray = new byte[width * height * 4];
            loadImage.CopyPixels(SourceImageArray, width * 4, 0);
        }

        public WriteableBitmap GetWriteableBitmap(byte[] arrayImage)
        {
            var writeBitmap = new WriteableBitmap(LoadImage);
            writeBitmap.WritePixels(
                new Int32Rect(0, 0, LoadImage.PixelWidth, LoadImage.PixelHeight),
                arrayImage, LoadImage.PixelWidth * 4, 0);
            return writeBitmap;
        }

        public byte[] GetLogarithmImage(int baseLog, int coefLog)
        {
            if (LoadImage == null || SourceImageArray == null) return null;
            var logImageArray = new byte[SourceImageArray.Length];
            for (int i = 0; i < logImageArray.Length; i += 4)
            {
                for (int j = 0; j < 3; j++)
                    logImageArray[i + j] = (byte)(coefLog * Math.Log(1 + SourceImageArray[i + j], baseLog));
                logImageArray[i + 3] = SourceImageArray[i + 3];
            }
            return logImageArray;

        }

        public byte[] GetRefernceColorCorrection()
        {
            if (SourceImageArray == null || LoadImage == null) return null;
            ReferenceColorImageArray = new byte[SourceImageArray.Length];
            for (int i = 0; i < ReferenceColorImageArray.Length; i += 4) 
            {
                double bTemp = SourceImageArray[i] * (ReferenceColorB / SourceColorB + 1);
                double gTemp = SourceImageArray[i + 1] * (ReferenceColorG / SourceColorG + 1);
                double rTemp = SourceImageArray[i + 2] * (ReferenceColorR / SourceColorR + 1);

                ReferenceColorImageArray[i] = CutPixel(bTemp);
                ReferenceColorImageArray[i + 1] = CutPixel(gTemp);
                ReferenceColorImageArray[i + 2] = CutPixel(rTemp);
                ReferenceColorImageArray[i + 3] = SourceImageArray[i + 3];
            }
            return ReferenceColorImageArray;
        }

        public byte[] GetDegreeImage(int degree, int coef)
        {
            if (LoadImage == null || SourceImageArray == null) return null;
            var degreeImageArray = new byte[SourceImageArray.Length];
            for (int i = 0; i < degreeImageArray.Length; i += 4) 
            {
                for (int j = 0; j < 3; j++)
                {
                    var pixel = coef * Math.Pow(SourceImageArray[i + j], degree);
                    if (pixel > 255) pixel = 255;
                    else if (pixel < 0) pixel = 0;
                    degreeImageArray[i + j] = (byte)pixel;
                }
                degreeImageArray[i + 3] = SourceImageArray[i + 3];
            }
            return degreeImageArray;
        }

        public void ConvertImageToArrays() //Gray, Negative, GrayWorld
        {
            if (SourceImageArray == null) return;
            GrayscaleImageArray = new byte[SourceImageArray.Length];
            NegativeImageArray = new byte[SourceImageArray.Length];
            GrayWorldImageArray = new byte[SourceImageArray.Length];
            int blueSumChannel = 0;
            int greenSumChannel = 0;
            int redSumChannel = 0;
            for (int i = 0; i < SourceImageArray.Length; i += 4) 
            {
                var alpha = SourceImageArray[i + 3];
                byte average = (byte)((SourceImageArray[i] + SourceImageArray[i + 1] + SourceImageArray[i + 2]) / 3);
                GrayscaleImageArray[i] = average;
                GrayscaleImageArray[i + 1] = average;
                GrayscaleImageArray[i + 2] = average;
                GrayscaleImageArray[i + 3] = alpha;
                NegativeImageArray[i] = (byte)(255 - SourceImageArray[i]);
                NegativeImageArray[i + 1] = (byte)(255 - SourceImageArray[i + 1]);
                NegativeImageArray[i + 2] = (byte)(255 - SourceImageArray[i + 2]);
                NegativeImageArray[i + 3] = alpha;
                blueSumChannel += SourceImageArray[i];
                greenSumChannel += SourceImageArray[i + 1];
                redSumChannel += SourceImageArray[i + 2];
            }
            blueSumChannel /= LoadImage.PixelWidth * LoadImage.PixelHeight;
            greenSumChannel /= LoadImage.PixelWidth * LoadImage.PixelHeight;
            redSumChannel /= LoadImage.PixelWidth * LoadImage.PixelHeight;
            int averageValueChannels = (blueSumChannel + greenSumChannel + redSumChannel) / 3;
            for (int i = 0; i < SourceImageArray.Length; i += 4)
            {
                var b = (byte)(SourceImageArray[i] * (averageValueChannels / blueSumChannel));
                var g = (byte)(SourceImageArray[i + 1] * (averageValueChannels / greenSumChannel));
                var r = (byte)(SourceImageArray[i + 2] * (averageValueChannels / redSumChannel));
                GrayWorldImageArray[i] = b;
                GrayWorldImageArray[i + 1] = g;
                GrayWorldImageArray[i + 2] = r;
                GrayWorldImageArray[i + 3] = SourceImageArray[i + 3];
            }
        }

        private byte CutPixel(double pixel)
        {
            if (pixel > 255) return 255;
            else if (pixel < 0) return 0;
            return (byte)pixel;
        }
    }
}
