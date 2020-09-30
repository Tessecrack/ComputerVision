using System;
using System.Windows.Forms;
using System.Drawing;

namespace BinarizationImage
{
    public partial class Form1 : Form
    {
        Bitmap sourceImage;
        public Form1()
        {
            InitializeComponent();
            sourceImage = null;
        }
        private bool CheckerSourceImage()
        {
            if (sourceImage == null) { MessageBox.Show("Исходного изображения нет"); return false; }
            return true;
        }
        private void button1_Click(object sender, EventArgs e) // закрыть
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e) // загрузить изображение
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp",
                Title = "Выбрать изображение"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sourceImage = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Не удалось загрузить изображение");
                }
            }
            if (sourceImage != null)
            {
                pictureBoxImage.Image = sourceImage;
                labelTypeImage.Text = "Исходное изображение";
                labelSizeImage.Text = sourceImage.Width.ToString() + " x " + sourceImage.Height.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e) // исходное изображение
        {
            if (!CheckerSourceImage()) return;
            pictureBoxImage.Image = sourceImage;
            labelTypeImage.Text = "Исходное изображение";
            pictureBoxImage.Image.Save("Source.jpg");
        }
        private void button5_Click(object sender, EventArgs e) // полутоновое изображение
        {
            if (!CheckerSourceImage()) return;
            pictureBoxImage.Image = sourceImage.GrayscaleImage();
            labelTypeImage.Text = "Полутоновое изображение";
            pictureBoxImage.Image.Save("Gray.jpg");
        }
        private void button4_Click(object sender, EventArgs e) // ручная бинаризация
        {
            if (!CheckerSourceImage()) return;
            int limit = 100;
            if (int.TryParse(textBoxLimit.Text, out _)) limit = int.Parse(textBoxLimit.Text);
            pictureBoxImage.Image = sourceImage.BinarizationWithLimit(limit, checkBoxReverse.Checked);
            labelTypeImage.Text = "Ручная бинаризация";
            pictureBoxImage.Image.Save("Binary_Limit_" + limit.ToString() + "_" + checkBoxReverse.Checked + ".jpg");
        }
        private void button6_Click(object sender, EventArgs e) // бинаризация с диапазоном
        {
            if (!CheckerSourceImage()) return;
            int fromLimit = 50, toLimit = 100;
            var userInput = textBoxLimit.Text.Split(' ', ',', '-');
            if (userInput.Length != 2)
            {
                MessageBox.Show("Неверно введен диапазон");
                return;
            }
            if (int.TryParse(userInput[0], out _)) fromLimit = int.Parse(userInput[0]);
            else { MessageBox.Show("Неверно введен начальный диапазон"); return; }
            if (int.TryParse(userInput[1], out _)) toLimit = int.Parse(userInput[1]);
            else { MessageBox.Show("Неверно введен конечный диапазон"); return; }

            pictureBoxImage.Image = sourceImage.BinarizationWithRange(fromLimit, toLimit, checkBoxReverse.Checked);
            labelTypeImage.Text = "Бинаризация с диапазоном";
            pictureBoxImage.Image.Save("Binary_Range_" + fromLimit.ToString() + "_"
                + toLimit.ToString() + "_"
                + checkBoxReverse.Checked +
                ".jpg");
        }

        private void button7_Click(object sender, EventArgs e) // глобальный метод оцу
        {
            if (!CheckerSourceImage()) return;
            int thresh = 0;
            pictureBoxImage.Image = sourceImage.BinarizationGlobalMethodOtsu(checkBoxReverse.Checked, ref thresh);
            labelThreshValue.Text = thresh.ToString();
            labelTypeImage.Text = "Глобальный метод Оцу";
            pictureBoxImage.Image.Save("GlobalMethodOtsu" + checkBoxReverse.Checked + ".jpg");
        }

        private void button8_Click(object sender, EventArgs e) // локальный метод оцу
        {
            if (!CheckerSourceImage()) return;
            int countParts = 4;
            if (int.TryParse(textBoxCountParts.Text, out _)) countParts = int.Parse(textBoxCountParts.Text);
            pictureBoxImage.Image = sourceImage.BinarizationLocalMethodOtsu(checkBoxReverse.Checked, countParts);
            labelTypeImage.Text = "Локальный метод Оцу";
            pictureBoxImage.Image.Save("LocalMethodOtsu_" + checkBoxReverse.Checked.ToString() + ".jpg");
        }

        private void button9_Click(object sender, EventArgs e) // иерархический метод оцу
        {
            if (!CheckerSourceImage()) return;
            int iterations = 10;
            pictureBoxImage.Image = sourceImage.BinarizationHierarchyMethodOtsu(iterations, checkBoxReverse.Checked);
            labelTypeImage.Text = "Иерархический метод Оцу";
            pictureBoxImage.Image.Save("HierarchyMethodOtsu.jpg");
        }

        private void button10_Click(object sender, EventArgs e)  // квантование по яркости
        {
            if (!CheckerSourceImage()) return;
            int levelQuant = 5;
            if (int.TryParse(textBoxQuanLevelNumber.Text, out _)) levelQuant = int.Parse(textBoxQuanLevelNumber.Text);
            pictureBoxImage.Image = sourceImage.QuantizedImage(levelQuant);
            labelTypeImage.Text = "Квантование по яркости";
            pictureBoxImage.Image.Save("QuantizedImage_" + levelQuant.ToString() + ".jpg");
        }
    }
}
