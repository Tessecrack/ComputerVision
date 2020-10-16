using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;
using LuminanceConversion.Models;
using System.Windows.Media.Imaging;

namespace LuminanceConversion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LuminanceConversionModels lumConModel;
        public MainWindow()
        {
            InitializeComponent();
            lumConModel = new LuminanceConversionModels();
            
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e) => this.Close();
        private void ButtonSaveImage_Click(object sender, RoutedEventArgs e)
        {
            var encoder = new JpegBitmapEncoder(); // Or PngBitmapEncoder, or whichever encoder you want
            encoder.Frames.Add(BitmapFrame.Create((BitmapSource)ImageBox.Source));
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                using (var stream = saveFileDialog.OpenFile())
                {
                    encoder.Save(stream);
                }
            }
        }
        private void ButtonUploadImage_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = new OpenFileDialog() 
            {
                Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*" 
            };
            if (fileDialog.ShowDialog() == true)
            {
                lumConModel.Name = fileDialog.FileName;
                Uri uri = new Uri(lumConModel.Name);
                lumConModel.LoadImage = new BitmapImage(uri);
                ImageBox.Source = lumConModel.LoadImage;
                lumConModel.ConvertSourceImageToPixelArray(lumConModel.LoadImage);
                lumConModel.ConvertImageToArrays();
            }
        }

        private void ButtonGrayScaleImage_Click(object sender, RoutedEventArgs e)
        {
            HelperSetArrayInImageBox(lumConModel.GrayscaleImageArray);
        }

        private void ButtonSourceImage_Click(object sender, RoutedEventArgs e)
        {
            HelperSetArrayInImageBox(lumConModel.SourceImageArray);
        }

        private void buttonNegative_Click(object sender, RoutedEventArgs e)
        {
            HelperSetArrayInImageBox(lumConModel.NegativeImageArray);
        }

        private void ButtonApplyGrayWorld_Click(object sender, RoutedEventArgs e)
        {
            HelperSetArrayInImageBox(lumConModel.GrayWorldImageArray);
        }

        private void ButtonApplyColorCorrection_Click(object sender, RoutedEventArgs e)
        {
            HelperSetArrayInImageBox(lumConModel.GetRefernceColorCorrection());
        }

        private void buttonLogarithm_Click(object sender, RoutedEventArgs e)
        {
            var paramsLogarithm = valuesLogarithm.Text.Split(' ');
            if (paramsLogarithm.Length != 2
                || !int.TryParse(paramsLogarithm[0], out int baseLog)
                || !int.TryParse(paramsLogarithm[1], out int coefLog))
                return;
            HelperSetArrayInImageBox(lumConModel.GetLogarithmImage(baseLog, coefLog));
        }

        private void ButtonDegree_Click(object sender, RoutedEventArgs e)
        {
            var paramsDegree = valuesDegree.Text.Split(' ');
            if (paramsDegree.Length != 2
                || !int.TryParse(paramsDegree[0], out int degree)
                || !int.TryParse(paramsDegree[1], out int coef))
                return;
            HelperSetArrayInImageBox(lumConModel.GetDegreeImage(degree, coef));
        }

        private void ColorPalleteImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var point = e.GetPosition((IInputElement)e.Source);
            HelperForRefernceColorCorrectionImage((BitmapSource)ColorPalleteImage.Source, point, 
                ref lumConModel.ReferenceColorB, 
                ref lumConModel.ReferenceColorG, 
                ref lumConModel.ReferenceColorR);
            PixelFromPallete.Text = String.Format("R:{0}, G:{1}, B:{2}", lumConModel.ReferenceColorR, lumConModel.ReferenceColorG, lumConModel.ReferenceColorB);
        }
        private void ImageBox_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var point = e.GetPosition((IInputElement)e.Source);
            HelperForRefernceColorCorrectionImage((BitmapSource)ImageBox.Source, point,
                ref lumConModel.SourceColorB,
                ref lumConModel.SourceColorG,
                ref lumConModel.SourceColorR);
            PixelFromImage.Text = String.Format("R:{0}, G:{1}, B:{2}", lumConModel.SourceColorR, lumConModel.SourceColorG, lumConModel.SourceColorB);
        }

        /*---HELPERS---*/

        private void HelperSetArrayInImageBox(byte[] arrayImage)
        {
            if (lumConModel.LoadImage == null || lumConModel.SourceImageArray == null || arrayImage == null) return;
            ImageBox.Source = lumConModel.GetWriteableBitmap(arrayImage);
        }

        private void HelperForRefernceColorCorrectionImage(BitmapSource bitmap, Point point, ref byte b, ref byte g, ref byte r)
        {
            var width = bitmap.PixelWidth;
            var height = bitmap.PixelHeight;
            if (bitmap.Format != PixelFormats.Bgra32)
                bitmap = new FormatConvertedBitmap(bitmap, PixelFormats.Bgra32, null, 0);
            byte[] arrayImage = new byte[width * height * 4];
            bitmap.CopyPixels(arrayImage, width * 4, 0);
            int index = (int)point.Y * height + (int)point.X * 4;
            b = arrayImage[index];
            g = arrayImage[index + 1];
            r = arrayImage[index + 2];
        }
    }
}
