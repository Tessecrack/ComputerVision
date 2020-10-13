namespace ColorCorrectionWinForms
{
    partial class ColorCorrectionForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRGBcolorPalitre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCoordinatesPixel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCoordinatesPixel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSupportingColor = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5SizeImage = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5TypeImage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxAnti = new System.Windows.Forms.CheckBox();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.textBoxBaseLog = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.pictureBoxColorPalitre = new System.Windows.Forms.PictureBox();
            this.pictureBoxHystogram = new System.Windows.Forms.PictureBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPalitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHystogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(908, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Загрузить изображение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelRGBcolorPalitre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.labelCoordinatesPixel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxCoordinatesPixel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxSupportingColor);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(382, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 156);
            this.panel1.TabIndex = 3;
            // 
            // labelRGBcolorPalitre
            // 
            this.labelRGBcolorPalitre.AutoSize = true;
            this.labelRGBcolorPalitre.Location = new System.Drawing.Point(146, 97);
            this.labelRGBcolorPalitre.Name = "labelRGBcolorPalitre";
            this.labelRGBcolorPalitre.Size = new System.Drawing.Size(13, 17);
            this.labelRGBcolorPalitre.TabIndex = 16;
            this.labelRGBcolorPalitre.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Выбранный цвет:";
            // 
            // labelCoordinatesPixel
            // 
            this.labelCoordinatesPixel.AutoSize = true;
            this.labelCoordinatesPixel.Location = new System.Drawing.Point(146, 74);
            this.labelCoordinatesPixel.Name = "labelCoordinatesPixel";
            this.labelCoordinatesPixel.Size = new System.Drawing.Size(13, 17);
            this.labelCoordinatesPixel.TabIndex = 14;
            this.labelCoordinatesPixel.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Выбранный пиксель:";
            // 
            // textBoxCoordinatesPixel
            // 
            this.textBoxCoordinatesPixel.Location = new System.Drawing.Point(146, 47);
            this.textBoxCoordinatesPixel.Name = "textBoxCoordinatesPixel";
            this.textBoxCoordinatesPixel.Size = new System.Drawing.Size(100, 22);
            this.textBoxCoordinatesPixel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Координаты пикселя:";
            // 
            // textBoxSupportingColor
            // 
            this.textBoxSupportingColor.Location = new System.Drawing.Point(146, 20);
            this.textBoxSupportingColor.Name = "textBoxSupportingColor";
            this.textBoxSupportingColor.Size = new System.Drawing.Size(100, 22);
            this.textBoxSupportingColor.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Применить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите опорный цвет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Коррекция с опорным цветом";
            // 
            // label5SizeImage
            // 
            this.label5SizeImage.AutoSize = true;
            this.label5SizeImage.Location = new System.Drawing.Point(300, 549);
            this.label5SizeImage.Name = "label5SizeImage";
            this.label5SizeImage.Size = new System.Drawing.Size(13, 17);
            this.label5SizeImage.TabIndex = 10;
            this.label5SizeImage.Text = "-";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 22);
            this.button4.TabIndex = 4;
            this.button4.Text = "Исходное изображение";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(382, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 45);
            this.panel2.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(81, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Применить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Серый мир";
            // 
            // label5TypeImage
            // 
            this.label5TypeImage.AutoSize = true;
            this.label5TypeImage.Location = new System.Drawing.Point(20, 549);
            this.label5TypeImage.Name = "label5TypeImage";
            this.label5TypeImage.Size = new System.Drawing.Size(98, 17);
            this.label5TypeImage.TabIndex = 6;
            this.label5TypeImage.Text = "Изображение";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBoxAnti);
            this.panel3.Controls.Add(this.textBoxPower);
            this.panel3.Controls.Add(this.textBoxBaseLog);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(382, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 143);
            this.panel3.TabIndex = 7;
            // 
            // checkBoxAnti
            // 
            this.checkBoxAnti.AutoSize = true;
            this.checkBoxAnti.Location = new System.Drawing.Point(142, 110);
            this.checkBoxAnti.Name = "checkBoxAnti";
            this.checkBoxAnti.Size = new System.Drawing.Size(177, 21);
            this.checkBoxAnti.TabIndex = 6;
            this.checkBoxAnti.Text = "Анти-преобразование";
            this.checkBoxAnti.UseVisualStyleBackColor = true;
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(134, 75);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(145, 22);
            this.textBoxPower.TabIndex = 5;
            this.textBoxPower.Text = "(степень) (коэффициент)";
            // 
            // textBoxBaseLog
            // 
            this.textBoxBaseLog.Location = new System.Drawing.Point(134, 42);
            this.textBoxBaseLog.Name = "textBoxBaseLog";
            this.textBoxBaseLog.Size = new System.Drawing.Size(145, 22);
            this.textBoxBaseLog.TabIndex = 4;
            this.textBoxBaseLog.Text = "(основание) (коэффициент)";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 27);
            this.button8.TabIndex = 3;
            this.button8.Text = "Степень";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 27);
            this.button7.TabIndex = 2;
            this.button7.Text = "Логарифм";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 27);
            this.button6.TabIndex = 1;
            this.button6.Text = "Негатив";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Основные яркостные преобразования";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(382, 473);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(296, 32);
            this.button9.TabIndex = 4;
            this.button9.Text = "Нормализация изображения";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(382, 511);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(296, 32);
            this.button10.TabIndex = 8;
            this.button10.Text = "Эквализация изображения";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(382, 80);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(296, 25);
            this.button11.TabIndex = 9;
            this.button11.Text = "Полутоновое изображение";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(684, 511);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(202, 32);
            this.button12.TabIndex = 2;
            this.button12.Text = "Построение гистограммы";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // pictureBoxColorPalitre
            // 
            this.pictureBoxColorPalitre.Image = global::ColorCorrectionWinForms.Properties.Resources.Colors2;
            this.pictureBoxColorPalitre.Location = new System.Drawing.Point(684, 21);
            this.pictureBoxColorPalitre.Name = "pictureBoxColorPalitre";
            this.pictureBoxColorPalitre.Size = new System.Drawing.Size(312, 313);
            this.pictureBoxColorPalitre.TabIndex = 11;
            this.pictureBoxColorPalitre.TabStop = false;
            this.pictureBoxColorPalitre.Click += new System.EventHandler(this.pictureBoxColorPalitre_Click);
            // 
            // pictureBoxHystogram
            // 
            this.pictureBoxHystogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHystogram.Location = new System.Drawing.Point(684, 379);
            this.pictureBoxHystogram.Name = "pictureBoxHystogram";
            this.pictureBoxHystogram.Size = new System.Drawing.Size(333, 126);
            this.pictureBoxHystogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHystogram.TabIndex = 10;
            this.pictureBoxHystogram.TabStop = false;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImage.Location = new System.Drawing.Point(23, 21);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(337, 522);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 1;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(753, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Палитра цветов (клик на область)";
            // 
            // ColorCorrectionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1036, 580);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBoxColorPalitre);
            this.Controls.Add(this.label5SizeImage);
            this.Controls.Add(this.pictureBoxHystogram);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5TypeImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorCorrectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photoshop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPalitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHystogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSupportingColor;
        private System.Windows.Forms.Label label5SizeImage;
        private System.Windows.Forms.Label label5TypeImage;
        private System.Windows.Forms.TextBox textBoxCoordinatesPixel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.PictureBox pictureBoxHystogram;
        private System.Windows.Forms.PictureBox pictureBoxColorPalitre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelRGBcolorPalitre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCoordinatesPixel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBaseLog;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.CheckBox checkBoxAnti;
    }
}

