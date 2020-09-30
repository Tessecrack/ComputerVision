namespace BinarizationImage
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelTypeImage = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelSizeImage = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLimit = new System.Windows.Forms.TextBox();
            this.checkBoxReverse = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.labelThresh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelThreshValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxCountParts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQuanLevelNumber = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(422, 469);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 1;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelTypeImage
            // 
            this.labelTypeImage.AutoSize = true;
            this.labelTypeImage.Location = new System.Drawing.Point(-2, 500);
            this.labelTypeImage.Name = "labelTypeImage";
            this.labelTypeImage.Size = new System.Drawing.Size(127, 13);
            this.labelTypeImage.TabIndex = 2;
            this.labelTypeImage.Text = "Исходное изображение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Загрузить изображение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Исходное изображение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelSizeImage
            // 
            this.labelSizeImage.AutoSize = true;
            this.labelSizeImage.Location = new System.Drawing.Point(335, 500);
            this.labelSizeImage.Name = "labelSizeImage";
            this.labelSizeImage.Size = new System.Drawing.Size(10, 13);
            this.labelSizeImage.TabIndex = 5;
            this.labelSizeImage.Text = "-";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(500, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ручная бинаризация";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(500, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 30);
            this.button5.TabIndex = 7;
            this.button5.Text = "Полутоновое изображение";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Порог";
            // 
            // textBoxLimit
            // 
            this.textBoxLimit.Location = new System.Drawing.Point(59, 24);
            this.textBoxLimit.Name = "textBoxLimit";
            this.textBoxLimit.Size = new System.Drawing.Size(70, 20);
            this.textBoxLimit.TabIndex = 1;
            this.textBoxLimit.Text = "100";
            // 
            // checkBoxReverse
            // 
            this.checkBoxReverse.AutoSize = true;
            this.checkBoxReverse.Location = new System.Drawing.Point(143, 26);
            this.checkBoxReverse.Name = "checkBoxReverse";
            this.checkBoxReverse.Size = new System.Drawing.Size(63, 17);
            this.checkBoxReverse.TabIndex = 2;
            this.checkBoxReverse.Text = "Реверс";
            this.checkBoxReverse.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkBoxReverse);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxLimit);
            this.panel2.Location = new System.Drawing.Point(440, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 54);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ручная бинаризация";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(500, 156);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(213, 31);
            this.button6.TabIndex = 9;
            this.button6.Text = "Бинаризация с диапазоном";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(500, 193);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(213, 31);
            this.button7.TabIndex = 10;
            this.button7.Text = "Глобальный метод Оцу";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(500, 230);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(213, 31);
            this.button8.TabIndex = 11;
            this.button8.Text = "Локальный метод Оцу";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(500, 267);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(213, 31);
            this.button9.TabIndex = 12;
            this.button9.Text = "Иерархический метод Оцу";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // labelThresh
            // 
            this.labelThresh.AutoSize = true;
            this.labelThresh.Location = new System.Drawing.Point(3, 14);
            this.labelThresh.Name = "labelThresh";
            this.labelThresh.Size = new System.Drawing.Size(97, 13);
            this.labelThresh.TabIndex = 13;
            this.labelThresh.Text = "Найденный порог";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelThreshValue);
            this.panel1.Controls.Add(this.labelThresh);
            this.panel1.Location = new System.Drawing.Point(440, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 40);
            this.panel1.TabIndex = 14;
            // 
            // labelThreshValue
            // 
            this.labelThreshValue.AutoSize = true;
            this.labelThreshValue.Location = new System.Drawing.Point(96, 14);
            this.labelThreshValue.Name = "labelThreshValue";
            this.labelThreshValue.Size = new System.Drawing.Size(10, 13);
            this.labelThreshValue.TabIndex = 14;
            this.labelThreshValue.Text = "-";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxCountParts);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(577, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 40);
            this.panel3.TabIndex = 15;
            // 
            // textBoxCountParts
            // 
            this.textBoxCountParts.Location = new System.Drawing.Point(87, 11);
            this.textBoxCountParts.Name = "textBoxCountParts";
            this.textBoxCountParts.Size = new System.Drawing.Size(42, 20);
            this.textBoxCountParts.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кол-во частей";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(500, 304);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(213, 31);
            this.button10.TabIndex = 6;
            this.button10.Text = "Квантование по яркости";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Количество уровней квантования";
            // 
            // textBoxQuanLevelNumber
            // 
            this.textBoxQuanLevelNumber.Location = new System.Drawing.Point(192, 7);
            this.textBoxQuanLevelNumber.Name = "textBoxQuanLevelNumber";
            this.textBoxQuanLevelNumber.Size = new System.Drawing.Size(72, 20);
            this.textBoxQuanLevelNumber.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxQuanLevelNumber);
            this.panel4.Location = new System.Drawing.Point(440, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 33);
            this.panel4.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(735, 536);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labelSizeImage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelTypeImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бинаризация изображения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelTypeImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelSizeImage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxReverse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label labelThresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelThreshValue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCountParts;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQuanLevelNumber;
        private System.Windows.Forms.Panel panel4;
    }
}

