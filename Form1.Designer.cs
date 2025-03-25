namespace DeQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelAngka1 = new Label();
            labelAngka2 = new Label();
            labelOperasi = new Label();
            labelNomorQuiz = new Label();
            labelSamaDengan = new Label();
            buttonStart = new Button();
            buttonStop = new Button();
            textBoxHasil = new TextBox();
            buttonEnter = new Button();
            labelPoint = new Label();
            labelHasilPoint = new Label();
            labelMinute = new Label();
            labelSeconds = new Label();
            labelTitikDua = new Label();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelAngka1
            // 
            labelAngka1.AutoSize = true;
            labelAngka1.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAngka1.Location = new Point(331, 160);
            labelAngka1.Name = "labelAngka1";
            labelAngka1.Size = new Size(33, 37);
            labelAngka1.TabIndex = 0;
            labelAngka1.Text = "?";
            // 
            // labelAngka2
            // 
            labelAngka2.AutoSize = true;
            labelAngka2.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAngka2.Location = new Point(437, 160);
            labelAngka2.Name = "labelAngka2";
            labelAngka2.Size = new Size(33, 37);
            labelAngka2.TabIndex = 1;
            labelAngka2.Text = "?";
            // 
            // labelOperasi
            // 
            labelOperasi.AutoSize = true;
            labelOperasi.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOperasi.Location = new Point(392, 160);
            labelOperasi.Name = "labelOperasi";
            labelOperasi.Size = new Size(29, 37);
            labelOperasi.TabIndex = 2;
            labelOperasi.Text = "-";
            // 
            // labelNomorQuiz
            // 
            labelNomorQuiz.AutoSize = true;
            labelNomorQuiz.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNomorQuiz.Location = new Point(235, 160);
            labelNomorQuiz.Name = "labelNomorQuiz";
            labelNomorQuiz.Size = new Size(66, 37);
            labelNomorQuiz.TabIndex = 3;
            labelNomorQuiz.Text = "No.";
            // 
            // labelSamaDengan
            // 
            labelSamaDengan.AutoSize = true;
            labelSamaDengan.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSamaDengan.Location = new Point(494, 160);
            labelSamaDengan.Name = "labelSamaDengan";
            labelSamaDengan.Size = new Size(35, 37);
            labelSamaDengan.TabIndex = 4;
            labelSamaDengan.Text = "=";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(279, 313);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(398, 313);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(94, 29);
            buttonStop.TabIndex = 6;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // textBoxHasil
            // 
            textBoxHasil.Location = new Point(554, 170);
            textBoxHasil.Name = "textBoxHasil";
            textBoxHasil.PlaceholderText = "Masukkan Hasil";
            textBoxHasil.Size = new Size(125, 27);
            textBoxHasil.TabIndex = 7;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(554, 213);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(94, 29);
            buttonEnter.TabIndex = 8;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // labelPoint
            // 
            labelPoint.AutoSize = true;
            labelPoint.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPoint.Location = new Point(545, 9);
            labelPoint.Name = "labelPoint";
            labelPoint.Size = new Size(103, 37);
            labelPoint.TabIndex = 9;
            labelPoint.Text = "Point:";
            // 
            // labelHasilPoint
            // 
            labelHasilPoint.AutoSize = true;
            labelHasilPoint.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHasilPoint.Location = new Point(654, 9);
            labelHasilPoint.Name = "labelHasilPoint";
            labelHasilPoint.Size = new Size(33, 37);
            labelHasilPoint.TabIndex = 10;
            labelHasilPoint.Text = "?";
            // 
            // labelMinute
            // 
            labelMinute.AutoSize = true;
            labelMinute.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMinute.Location = new Point(642, 60);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(55, 37);
            labelMinute.TabIndex = 13;
            labelMinute.Text = "00";
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSeconds.Location = new Point(716, 60);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(55, 37);
            labelSeconds.TabIndex = 11;
            labelSeconds.Text = "00";
            // 
            // labelTitikDua
            // 
            labelTitikDua.AutoSize = true;
            labelTitikDua.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitikDua.Location = new Point(694, 60);
            labelTitikDua.Name = "labelTitikDua";
            labelTitikDua.Size = new Size(27, 37);
            labelTitikDua.TabIndex = 14;
            labelTitikDua.Text = ":";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.Location = new Point(551, 60);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(97, 37);
            labelTime.TabIndex = 15;
            labelTime.Text = "Time:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTime);
            Controls.Add(labelTitikDua);
            Controls.Add(labelMinute);
            Controls.Add(labelSeconds);
            Controls.Add(labelHasilPoint);
            Controls.Add(labelPoint);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxHasil);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(labelSamaDengan);
            Controls.Add(labelNomorQuiz);
            Controls.Add(labelOperasi);
            Controls.Add(labelAngka2);
            Controls.Add(labelAngka1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAngka1;
        private Label labelAngka2;
        private Label labelOperasi;
        private Label labelNomorQuiz;
        private Label labelSamaDengan;
        private Button buttonStart;
        private Button buttonStop;
        private TextBox textBoxHasil;
        private Button buttonEnter;
        private Label labelPoint;
        private Label labelHasilPoint;
        private Label labelMinute;
        private Label labelSeconds;
        private Label labelTitikDua;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
    }
}
