namespace SpatialFilter
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laplaciantextBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sourceImageBox1 = new Emgu.CV.UI.ImageBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imageBox3SourceOrLaplacian = new Emgu.CV.UI.ImageBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.sobelYORDERtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sobelXORDERtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.operatorSobelAperturetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sobelImageBox1 = new Emgu.CV.UI.ImageBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.medianTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.medianFilterImageBox = new Emgu.CV.UI.ImageBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.operationANDpictureBox = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.sourceOrImageBox = new Emgu.CV.UI.ImageBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.gammaTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImageBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3SourceOrLaplacian)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobelImageBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medianFilterImageBox)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationANDpictureBox)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceOrImageBox)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1284, 659);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem});
            this.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1445, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(76, 506);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходное изображение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(119, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Лапласиан";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(80, 500);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Исходное OR Лапласиан";
            // 
            // laplaciantextBox1
            // 
            this.laplaciantextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.laplaciantextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laplaciantextBox1.ForeColor = System.Drawing.Color.Orange;
            this.laplaciantextBox1.Location = new System.Drawing.Point(279, 10);
            this.laplaciantextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.laplaciantextBox1.Name = "laplaciantextBox1";
            this.laplaciantextBox1.Size = new System.Drawing.Size(32, 24);
            this.laplaciantextBox1.TabIndex = 10;
            this.laplaciantextBox1.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.laplaciantextBox1);
            this.panel1.Location = new System.Drawing.Point(4, 519);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 52);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Высветлить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(145, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Значение ядра";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 47);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1413, 590);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sourceImageBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 578);
            this.panel2.TabIndex = 13;
            // 
            // sourceImageBox1
            // 
            this.sourceImageBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sourceImageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceImageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.sourceImageBox1.Location = new System.Drawing.Point(4, 4);
            this.sourceImageBox1.Margin = new System.Windows.Forms.Padding(4);
            this.sourceImageBox1.Name = "sourceImageBox1";
            this.sourceImageBox1.Size = new System.Drawing.Size(319, 492);
            this.sourceImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourceImageBox1.TabIndex = 2;
            this.sourceImageBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.imageBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(345, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 578);
            this.panel3.TabIndex = 13;
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox1.Location = new System.Drawing.Point(7, 4);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(319, 492);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.imageBox3SourceOrLaplacian);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(686, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 578);
            this.panel4.TabIndex = 13;
            // 
            // imageBox3SourceOrLaplacian
            // 
            this.imageBox3SourceOrLaplacian.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imageBox3SourceOrLaplacian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox3SourceOrLaplacian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBox3SourceOrLaplacian.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox3SourceOrLaplacian.Location = new System.Drawing.Point(7, 4);
            this.imageBox3SourceOrLaplacian.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox3SourceOrLaplacian.Name = "imageBox3SourceOrLaplacian";
            this.imageBox3SourceOrLaplacian.Size = new System.Drawing.Size(319, 492);
            this.imageBox3SourceOrLaplacian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox3SourceOrLaplacian.TabIndex = 2;
            this.imageBox3SourceOrLaplacian.TabStop = false;
            this.imageBox3SourceOrLaplacian.Click += new System.EventHandler(this.imageBox3SourceOrLaplacian_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.sobelImageBox1);
            this.panel5.Location = new System.Drawing.Point(1027, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 578);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.sobelYORDERtextBox);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.sobelXORDERtextBox);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.operatorSobelAperturetextBox);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(4, 517);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(322, 55);
            this.panel6.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(8, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "Высветлить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sobelYORDERtextBox
            // 
            this.sobelYORDERtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sobelYORDERtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sobelYORDERtextBox.ForeColor = System.Drawing.Color.Orange;
            this.sobelYORDERtextBox.Location = new System.Drawing.Point(244, 1);
            this.sobelYORDERtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sobelYORDERtextBox.Name = "sobelYORDERtextBox";
            this.sobelYORDERtextBox.Size = new System.Drawing.Size(32, 24);
            this.sobelYORDERtextBox.TabIndex = 17;
            this.sobelYORDERtextBox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(223, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y: ";
            // 
            // sobelXORDERtextBox
            // 
            this.sobelXORDERtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sobelXORDERtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sobelXORDERtextBox.ForeColor = System.Drawing.Color.Orange;
            this.sobelXORDERtextBox.Location = new System.Drawing.Point(183, 1);
            this.sobelXORDERtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sobelXORDERtextBox.Name = "sobelXORDERtextBox";
            this.sobelXORDERtextBox.Size = new System.Drawing.Size(32, 24);
            this.sobelXORDERtextBox.TabIndex = 15;
            this.sobelXORDERtextBox.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(163, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "X: ";
            // 
            // operatorSobelAperturetextBox
            // 
            this.operatorSobelAperturetextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.operatorSobelAperturetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorSobelAperturetextBox.ForeColor = System.Drawing.Color.Orange;
            this.operatorSobelAperturetextBox.Location = new System.Drawing.Point(123, 3);
            this.operatorSobelAperturetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.operatorSobelAperturetextBox.Name = "operatorSobelAperturetextBox";
            this.operatorSobelAperturetextBox.Size = new System.Drawing.Size(32, 24);
            this.operatorSobelAperturetextBox.TabIndex = 13;
            this.operatorSobelAperturetextBox.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Значение ядра";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(111, 497);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Оператор Собеля";
            // 
            // sobelImageBox1
            // 
            this.sobelImageBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sobelImageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sobelImageBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sobelImageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.sobelImageBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.sobelImageBox1.Location = new System.Drawing.Point(7, 4);
            this.sobelImageBox1.Margin = new System.Windows.Forms.Padding(4);
            this.sobelImageBox1.Name = "sobelImageBox1";
            this.sobelImageBox1.Size = new System.Drawing.Size(319, 492);
            this.sobelImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sobelImageBox1.TabIndex = 2;
            this.sobelImageBox1.TabStop = false;
            this.sobelImageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.medianFilterImageBox);
            this.panel7.Location = new System.Drawing.Point(4, 590);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(333, 578);
            this.panel7.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.medianTextBox);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(4, 517);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(319, 55);
            this.panel8.TabIndex = 10;
            // 
            // medianTextBox
            // 
            this.medianTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.medianTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medianTextBox.ForeColor = System.Drawing.Color.Orange;
            this.medianTextBox.Location = new System.Drawing.Point(216, 12);
            this.medianTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.medianTextBox.Name = "medianTextBox";
            this.medianTextBox.Size = new System.Drawing.Size(32, 24);
            this.medianTextBox.TabIndex = 13;
            this.medianTextBox.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Orange;
            this.label11.Location = new System.Drawing.Point(99, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Размер ядра";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Orange;
            this.label12.Location = new System.Drawing.Point(88, 497);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Усредняющий фильтр";
            // 
            // medianFilterImageBox
            // 
            this.medianFilterImageBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.medianFilterImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medianFilterImageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medianFilterImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.medianFilterImageBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.medianFilterImageBox.Location = new System.Drawing.Point(4, 4);
            this.medianFilterImageBox.Margin = new System.Windows.Forms.Padding(4);
            this.medianFilterImageBox.Name = "medianFilterImageBox";
            this.medianFilterImageBox.Size = new System.Drawing.Size(319, 492);
            this.medianFilterImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medianFilterImageBox.TabIndex = 2;
            this.medianFilterImageBox.TabStop = false;
            this.medianFilterImageBox.Click += new System.EventHandler(this.medianFilterImageBox_Click);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.operationANDpictureBox);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel11.Location = new System.Drawing.Point(345, 590);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(333, 578);
            this.panel11.TabIndex = 14;
            // 
            // operationANDpictureBox
            // 
            this.operationANDpictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.operationANDpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.operationANDpictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.operationANDpictureBox.Location = new System.Drawing.Point(4, 4);
            this.operationANDpictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.operationANDpictureBox.Name = "operationANDpictureBox";
            this.operationANDpictureBox.Size = new System.Drawing.Size(319, 492);
            this.operationANDpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.operationANDpictureBox.TabIndex = 7;
            this.operationANDpictureBox.TabStop = false;
            this.operationANDpictureBox.Click += new System.EventHandler(this.operationANDpictureBox_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Orange;
            this.label13.Location = new System.Drawing.Point(73, 508);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Сглаженное AND Резкое";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.sourceOrImageBox);
            this.panel9.Location = new System.Drawing.Point(686, 590);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(333, 578);
            this.panel9.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(80, 508);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Повышение резкости";
            // 
            // sourceOrImageBox
            // 
            this.sourceOrImageBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sourceOrImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceOrImageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sourceOrImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.sourceOrImageBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.sourceOrImageBox.Location = new System.Drawing.Point(7, 4);
            this.sourceOrImageBox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceOrImageBox.Name = "sourceOrImageBox";
            this.sourceOrImageBox.Size = new System.Drawing.Size(319, 492);
            this.sourceOrImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourceOrImageBox.TabIndex = 2;
            this.sourceOrImageBox.TabStop = false;
            this.sourceOrImageBox.Click += new System.EventHandler(this.sourceOrimageBox_Click);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.imageBox2);
            this.panel10.Location = new System.Drawing.Point(1027, 590);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(333, 578);
            this.panel10.TabIndex = 17;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.gammaTextBox);
            this.panel12.Controls.Add(this.label14);
            this.panel12.Location = new System.Drawing.Point(7, 524);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(319, 48);
            this.panel12.TabIndex = 11;
            // 
            // gammaTextBox
            // 
            this.gammaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gammaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gammaTextBox.ForeColor = System.Drawing.Color.Orange;
            this.gammaTextBox.Location = new System.Drawing.Point(205, 12);
            this.gammaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gammaTextBox.Name = "gammaTextBox";
            this.gammaTextBox.Size = new System.Drawing.Size(32, 24);
            this.gammaTextBox.TabIndex = 13;
            this.gammaTextBox.Text = "0,5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Orange;
            this.label14.Location = new System.Drawing.Point(131, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "gamma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(100, 505);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Гамма - коррекция";
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBox2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.imageBox2.Location = new System.Drawing.Point(7, 4);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(319, 492);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            this.imageBox2.Click += new System.EventHandler(this.imageBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1445, 712);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пространственная фильтрация";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImageBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3SourceOrLaplacian)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobelImageBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medianFilterImageBox)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationANDpictureBox)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceOrImageBox)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox laplaciantextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox operatorSobelAperturetextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sobelYORDERtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sobelXORDERtextBox;
        private System.Windows.Forms.Label label7;
        private Emgu.CV.UI.ImageBox sobelImageBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox medianTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Emgu.CV.UI.ImageBox medianFilterImageBox;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox operationANDpictureBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private Emgu.CV.UI.ImageBox sourceOrImageBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label9;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox gammaTextBox;
        private System.Windows.Forms.Label label14;
        private Emgu.CV.UI.ImageBox sourceImageBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox3SourceOrLaplacian;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

