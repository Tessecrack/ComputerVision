using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace ColorCorrectionWinForms
{
    public interface IColorCorrection
    {
        Bitmap sourceImage { get; set; }
        Bitmap grayImage { get; set; }
        Bitmap editImage { get; set; }
        Bitmap hystogram { get; set; }
        string fileName { get; set; }
    }

    public partial class ColorCorrectionForm : Form
    {
        public static Dictionary<string, Color> StringColor;
        Bitmap sourceImage;
        Bitmap grayImage;
        Bitmap editImage;
        Bitmap hystogram;
        string fileName;

        public ColorCorrectionForm()
        {
            InitializeComponent();
            sourceImage = null;
            StringColor = new Dictionary<string, Color>()
            {
                { "серый", Color.Gray},
                { "фиолетовый", Color.Violet },
                { "белый", Color.WhiteSmoke},
                { "желтый", Color.Yellow },
                { "золотой", Color.Gold },
                { "циан", Color.LightCyan },
                { "черный", Color.Black},
                { "корал", Color.Coral},
            };


        }
        private bool CheckSourceImage()
        {
            if (sourceImage == null)
            {
                MessageBox.Show("Изображение не загружено");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e) //загрузит изображение
        {
            var openFile = new OpenFileDialog()
            {
                Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }
            try
            {
                sourceImage = new Bitmap(fileName);
                pictureBoxImage.Image = sourceImage;
                label5SizeImage.Text = sourceImage.Width.ToString() + " x " + sourceImage.Height.ToString();
                label5TypeImage.Text = "Исходное изображение";
                editImage = new Bitmap(sourceImage);
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить изображение");
            }
        }
        private void button4_Click(object sender, EventArgs e) //исходное изображение
        {
            if (!CheckSourceImage()) return;
            editImage = new Bitmap(sourceImage);
            pictureBoxImage.Image = editImage;
            label5TypeImage.Text = "Исходное изображение";
        }
        private void button3_Click(object sender, EventArgs e) //коррекция с опорным цветом //286 124 54 59
        {
            if (!CheckSourceImage()) return;
            Bitmap palitre = new Bitmap(pictureBoxColorPalitre.Image);
            Color destinationColor, sourceColor;
            int coordinateX = 0, coordinateY = 0;
            if (labelRGBcolorPalitre.Text != "-" && labelCoordinatesPixel.Text != "-")
            {
                var strSrc = labelCoordinatesPixel.Text.Split(' ');
                var strDst = labelRGBcolorPalitre.Text.Split(' ');

                sourceColor = editImage.GetPixel(int.Parse(strSrc[0]), int.Parse(strSrc[1]));
                destinationColor = palitre.GetPixel(int.Parse(strDst[0]), int.Parse(strDst[1]));
            }
            else
            {
                try
                {
                    destinationColor = StringColor[textBoxSupportingColor.Text.ToLower()];
                }
                catch
                {
                    MessageBox.Show("Реализованы не все цвета :)");
                    return;
                }
                var str = textBoxCoordinatesPixel.Text.Split(' ', ',');
                if (str.Length != 2)
                {
                    MessageBox.Show("Неверно введены координаты");
                    return;
                }
                coordinateX = int.Parse(str[0]); coordinateY = int.Parse(str[1]);
                sourceColor = editImage.GetPixel(coordinateX, coordinateY);
            }
            if (coordinateX >= sourceImage.Width || coordinateY >= sourceImage.Height)
            {
                MessageBox.Show("Вне границ изображения");
                return;
            }
            editImage = LuminanceConversions.GetCorrectionImageBasedColor(editImage, destinationColor, sourceColor);
            pictureBoxImage.Image = editImage;
            editImage.Save(@"CorrectionBasedOnColor.jpg");
            label5TypeImage.Text = "Коррекция с опорным цветом";
        }
        private void button5_Click(object sender, EventArgs e) //серый мир
        {
            if (!CheckSourceImage()) return;
            editImage = LuminanceConversions.GetGrayWorld(editImage);
            pictureBoxImage.Image = editImage;
            editImage.Save(@"GrayWorld.jpg");
            if (editImage != null) label5TypeImage.Text = "Серый мир";
        }
        private void button6_Click(object sender, EventArgs e) // негатив
        {
            if (!CheckSourceImage()) return;
            editImage = LuminanceConversions.GetNegative(editImage);
            pictureBoxImage.Image = editImage;
            editImage.Save(@"Negative.jpg");
            if (editImage != null) label5TypeImage.Text = "Негатив";
        }
        private void button7_Click(object sender, EventArgs e) // логарифм
        {
            if (!CheckSourceImage()) return;
            var str = textBoxBaseLog.Text.Split(' ', ',');
            if (str.Length != 2)
            {
                MessageBox.Show("Для логарифма неверно введены основание и коэффициент");
                return;
            }

            int coef = 41;
            int baseLog;
            try
            {
                baseLog = int.Parse(str[0]); coef = int.Parse(str[1]);
            }
            catch
            {
                MessageBox.Show("Неверный ввод");
                return;
            }
            if (checkBoxAnti.Checked) editImage = LuminanceConversions.GetAntiLogarithm(editImage, baseLog, coef);
            else editImage = LuminanceConversions.GetLogarithmImage(editImage, baseLog, coef);
            pictureBoxImage.Image = editImage;
            editImage.Save(@"Logarithm.jpg");
            if (editImage != null) label5TypeImage.Text = "Логарифм";
        }
        private void button8_Click(object sender, EventArgs e) //степень
        {
            if (!CheckSourceImage()) return;
            var str = textBoxPower.Text.Split(' ');
            if (str.Length != 2)
            {
                MessageBox.Show("Для степени введены неверные значения");
                return;
            }
            double power;
            double coef;
            try
            {
                power = double.Parse(str[0]); coef = double.Parse(str[1]);
            }
            catch
            {
                MessageBox.Show("Неверный ввод");
                return;
            }
            editImage = checkBoxAnti.Checked ? LuminanceConversions.GetAntiPower(editImage, power, coef) :
                LuminanceConversions.GetPowerImage(editImage, power, coef);
            pictureBoxImage.Image = editImage;
            editImage.Save(@"Power.jpg");
            if (editImage != null) label5TypeImage.Text = "Степень";
        }
        private void button9_Click(object sender, EventArgs e) //нормализация изображения
        {
            if (!CheckSourceImage() || grayImage == null) return;
            editImage = LuminanceConversions.GetNormalizationImage(grayImage);
            double[] array = new double[256];
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                    array[editImage.GetPixel(x, y).R]++;
            pictureBoxImage.Image = editImage;
            pictureBoxHystogram.Image = GetHystogram(array);
            label5TypeImage.Text = "Нормализованное изображение";
            editImage.Save("Normalization.jpg");
        }
        private void button10_Click(object sender, EventArgs e) //эквализация гистограммы
        {
            if (!CheckSourceImage() || grayImage == null) return;
            editImage = LuminanceConversions.GetEqualizationImage(grayImage);
            double[] array = new double[256];
            for (int y = 0; y < editImage.Height; y++)
                for (int x = 0; x < editImage.Width; x++)
                    array[editImage.GetPixel(x, y).R]++;
            pictureBoxImage.Image = editImage;
            pictureBoxHystogram.Image = GetHystogram(array);
            label5TypeImage.Text = "Эквализированное изображение";
            editImage.Save("Equalization.jpg");
        }
        private void button11_Click(object sender, EventArgs e) // полутоновое изображение
        {
            if (!CheckSourceImage()) return;
            grayImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            grayImage = LuminanceConversions.GetGrayScaleImage(editImage);
            pictureBoxImage.Image = grayImage;
            label5TypeImage.Text = "Полутоновое изображение";
        }
        private void button12_Click(object sender, EventArgs e) //построение гистограммы
        {
            if (grayImage == null)
            {
                MessageBox.Show("Полутоновое изображение отсутствует");
                return;
            }
            double[] array = new double[256];
            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                    array[grayImage.GetPixel(x, y).R]++;
            hystogram = GetHystogram(array);
            pictureBoxHystogram.Image = hystogram;
            hystogram.Save("Hystogram.jpeg");
            MessageBox.Show("Гистограмма построена");
        }
        private Bitmap GetHystogram(double[] array)
        {
            int width = 256;
            int height = 250;
            var max = array.Max();
            for (int i = 0; i < array.Length; i++)
                array[i] = height * array[i] / max;
            Bitmap myHystogram = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    myHystogram.SetPixel(i, j, Color.White);
            for (int x = 0; x < width; x++)
                for (int y = height - 1; y >= height - array[x]; y--)
                    myHystogram.SetPixel(x, y, Color.Black);
            return myHystogram;
        }

        private void pictureBoxColorPalitre_Click(object sender, EventArgs e)
        {
            var click = (MouseEventArgs)e;
            try
            {
                labelRGBcolorPalitre.Text = click.X.ToString() + " " + click.Y.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            var click = (MouseEventArgs)e;
            try 
            {
                labelCoordinatesPixel.Text = click.X.ToString() + " " + click.Y.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
