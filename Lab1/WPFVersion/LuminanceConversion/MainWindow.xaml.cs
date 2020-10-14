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
                lumConModel.ConvertSourceImageToPixelArray();
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

        /*---HELPERS---*/

        private void HelperSetArrayInImageBox(byte[] arrayImage)
        {
            if (lumConModel.LoadImage == null || lumConModel.SourceImageArray == null) return;
            ImageBox.Source = lumConModel.GetWriteableBitmap(arrayImage);
        }
    }
}
