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
            buttonTryAgain = new Button();
            SuspendLayout();
            // 
            // labelAngka1
            // 
            labelAngka1.AutoSize = true;
            labelAngka1.Font = new Font("Bookman Old Style", 25.8000011F);
            labelAngka1.Location = new Point(237, 167);
            labelAngka1.Name = "labelAngka1";
            labelAngka1.Size = new Size(46, 52);
            labelAngka1.TabIndex = 0;
            labelAngka1.Text = "?";
            // 
            // labelAngka2
            // 
            labelAngka2.AutoSize = true;
            labelAngka2.Font = new Font("Bookman Old Style", 25.8000011F);
            labelAngka2.Location = new Point(374, 168);
            labelAngka2.Name = "labelAngka2";
            labelAngka2.Size = new Size(46, 52);
            labelAngka2.TabIndex = 1;
            labelAngka2.Text = "?";
            // 
            // labelOperasi
            // 
            labelOperasi.AutoSize = true;
            labelOperasi.Font = new Font("Bookman Old Style", 25.8000011F);
            labelOperasi.Location = new Point(315, 167);
            labelOperasi.Name = "labelOperasi";
            labelOperasi.Size = new Size(40, 52);
            labelOperasi.TabIndex = 2;
            labelOperasi.Text = "-";
            // 
            // labelNomorQuiz
            // 
            labelNomorQuiz.AutoSize = true;
            labelNomorQuiz.Font = new Font("Bookman Old Style", 25.8000011F);
            labelNomorQuiz.Location = new Point(128, 168);
            labelNomorQuiz.Name = "labelNomorQuiz";
            labelNomorQuiz.Size = new Size(94, 52);
            labelNomorQuiz.TabIndex = 3;
            labelNomorQuiz.Text = "No.";
            // 
            // labelSamaDengan
            // 
            labelSamaDengan.AutoSize = true;
            labelSamaDengan.Font = new Font("Bookman Old Style", 25.8000011F);
            labelSamaDengan.Location = new Point(444, 168);
            labelSamaDengan.Name = "labelSamaDengan";
            labelSamaDengan.Size = new Size(48, 52);
            labelSamaDengan.TabIndex = 4;
            labelSamaDengan.Text = "=";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(258, 299);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(115, 43);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(377, 299);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(115, 43);
            buttonStop.TabIndex = 6;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // textBoxHasil
            // 
            textBoxHasil.Location = new Point(517, 186);
            textBoxHasil.Name = "textBoxHasil";
            textBoxHasil.PlaceholderText = "Masukkan Hasil";
            textBoxHasil.Size = new Size(155, 27);
            textBoxHasil.TabIndex = 7;
            textBoxHasil.KeyDown += textBoxHasil_KeyDown;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(694, 185);
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
            labelPoint.Location = new Point(563, 46);
            labelPoint.Name = "labelPoint";
            labelPoint.Size = new Size(92, 37);
            labelPoint.TabIndex = 9;
            labelPoint.Text = "Poin:";
            // 
            // labelHasilPoint
            // 
            labelHasilPoint.AutoSize = true;
            labelHasilPoint.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHasilPoint.Location = new Point(661, 46);
            labelHasilPoint.Name = "labelHasilPoint";
            labelHasilPoint.Size = new Size(74, 37);
            labelHasilPoint.TabIndex = 10;
            labelHasilPoint.Text = "000";
            // 
            // labelMinute
            // 
            labelMinute.AutoSize = true;
            labelMinute.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMinute.Location = new Point(661, 9);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(55, 37);
            labelMinute.TabIndex = 13;
            labelMinute.Text = "00";
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSeconds.Location = new Point(735, 9);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(55, 37);
            labelSeconds.TabIndex = 11;
            labelSeconds.Text = "00";
            // 
            // labelTitikDua
            // 
            labelTitikDua.AutoSize = true;
            labelTitikDua.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitikDua.Location = new Point(713, 9);
            labelTitikDua.Name = "labelTitikDua";
            labelTitikDua.Size = new Size(27, 37);
            labelTitikDua.TabIndex = 14;
            labelTitikDua.Text = ":";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.Location = new Point(558, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(97, 37);
            labelTime.TabIndex = 15;
            labelTime.Text = "Time:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // buttonTryAgain
            // 
            buttonTryAgain.Location = new Point(498, 303);
            buttonTryAgain.Name = "buttonTryAgain";
            buttonTryAgain.Size = new Size(103, 39);
            buttonTryAgain.TabIndex = 16;
            buttonTryAgain.Text = "Coba Lagi";
            buttonTryAgain.UseVisualStyleBackColor = true;
            buttonTryAgain.Visible = false;
            buttonTryAgain.Click += buttonTryAgain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTryAgain);
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
            Text = "DeQuiz";
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
        private Button buttonTryAgain;
    }
}
