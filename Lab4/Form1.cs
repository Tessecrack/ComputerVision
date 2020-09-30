using System;
using System.Windows.Forms;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.Structure;

namespace SpatialFilter
{
    public partial class Form1 : Form
    {
        private void button3_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        string path = @"ProcessImage/";

        Image<Gray, float> sourceImage;
        Image<Gray, float> laplacianImage;
        Image<Gray, float> sourceOrLaplacianImage;
        Image<Gray, float> sobelImage;
        Image<Gray, float> averageImage;
        Image<Gray, float> imageOpAnd;
        Image<Gray, float> sharpnessImage;

        public Form1() => InitializeComponent();
        private void button1_Click(object sender, EventArgs e) => Close();
        private void LoadToolStripMenuItem_Click_1(object sender, EventArgs e) => LoadImage();
        private void LoadImage()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp",
                Title = "Выберите изображение"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sourceImage = new Image<Gray, float>(openFileDialog.FileName);
                    sourceImageBox1.Image = sourceImage;
                    sourceImage.Save(path + "1)SourceImage.png");
                }
                catch
                {
                    MessageBox.Show("Изображение не удалось загрузить");
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (laplacianImage == null) return;
            int apertureSize = 1;
            if (int.TryParse(laplaciantextBox1.Text, out apertureSize))
                if (apertureSize % 2 == 0 || apertureSize > 31)
                {
                    MessageBox.Show("Размер ядра должен быть нечетным и не превышать 31");
                    return;
                }
            imageBox1.Image = laplacianImage;
        }
        private void imageBox1_Click_1(object sender, EventArgs e) // лапласиан
        {
            if (e is MouseEventArgs) imageBox1.BorderStyle = BorderStyle.Fixed3D;
            if (sourceImage == null) return;
            int apertureSize = 1;
            if (int.TryParse(laplaciantextBox1.Text, out apertureSize))
                if (apertureSize % 2 == 0 || apertureSize > 31)
                {
                    MessageBox.Show("Размер ядра должен быть нечетным и не превышать 31");
                    return;
                }

            laplacianImage = sourceImage.Laplace(apertureSize);
            imageBox1.Image = laplacianImage;
            laplacianImage.Save(path + "2)Laplacian.png");
            imageBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void imageBox3SourceOrLaplacian_Click(object sender, EventArgs e) // лапласиан или исходное
        {
            if (e is MouseEventArgs) imageBox3SourceOrLaplacian.BorderStyle = BorderStyle.Fixed3D;
            if (sourceImage == null) return;

            sourceOrLaplacianImage = sourceImage + laplacianImage;
            imageBox3SourceOrLaplacian.Image = sourceOrLaplacianImage;
            sourceOrLaplacianImage.Save(path + "3)SourceOrLaplacian.png");
            imageBox3SourceOrLaplacian.BorderStyle = BorderStyle.FixedSingle;
        }
        

        private void imageBox1_Click(object sender, EventArgs e) // собель
        {
            if (e is MouseEventArgs) sobelImageBox1.BorderStyle = BorderStyle.Fixed3D;
            if (sourceImage == null) return;

            sobelImage = sourceImage.Sobel(
                int.Parse(sobelXORDERtextBox.Text),
                int.Parse(sobelYORDERtextBox.Text),
                int.Parse(operatorSobelAperturetextBox.Text));
            sobelImage.Save(path + "4)Sobel.png");
            sobelImageBox1.Image = sobelImage;
            sobelImageBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void medianFilterImageBox_Click(object sender, EventArgs e) // сглаживание
        {
            if (e is MouseEventArgs) sobelImageBox1.BorderStyle = BorderStyle.Fixed3D;
            if (sourceImage == null) return;

            averageImage = sourceImage.SmoothBlur(int.Parse(medianTextBox.Text), int.Parse(medianTextBox.Text));
            medianFilterImageBox.Image = averageImage;
            averageImage.Save(path + "5)Average.png");
            medianFilterImageBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void operationANDpictureBox_Click(object sender, EventArgs e) // 
        {
            if (e is MouseEventArgs) operationANDpictureBox.BorderStyle = BorderStyle.Fixed3D;
            if (sourceImage == null) return;

            imageOpAnd = sobelImage & averageImage;
            operationANDpictureBox.Image = imageOpAnd.Bitmap;
            imageOpAnd.Save(path + "6)OperationAND.png");
            operationANDpictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void sourceOrimageBox_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs) sourceOrImageBox.BorderStyle = BorderStyle.Fixed3D;
            if (sourceImage == null) return;

            sharpnessImage = imageOpAnd + sourceImage;

            sourceOrImageBox.Image = sharpnessImage;

            sharpnessImage.Save(path + "7)MoreSharpness.png");

            sourceOrImageBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void imageBox2_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs) imageBox2.BorderStyle = BorderStyle.Fixed3D;
            if (sourceImage == null) return;

            var image = new Image<Bgr, byte>(sharpnessImage.Bitmap);
            image._GammaCorrect(double.Parse(gammaTextBox.Text));

            imageBox2.Image = image;

            image.Save(path + "8)GammaCorrect.png");
            
            imageBox2.BorderStyle = BorderStyle.FixedSingle;
        }        
    }
}
