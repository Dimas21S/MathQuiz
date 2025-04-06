namespace DeQuiz
{
    public partial class Form1 : Form
    {
        int nomorQuiz;
        int angkaPertama;
        int angkaKedua;
        int hasil;
        int jawaban;
        int poin;
        int menit;
        int detik;
        string operation;
        Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                detik++;

                if (detik == 60)
                {
                    detik = 0;
                    menit++;
                }
            }

            if (menit == 5)
            {
                timer1.Enabled = false;
            }

            labelMinute.Text = menit.ToString("D2");
            labelSeconds.Text = detik.ToString("D2");
            buttonTryAgain.Visible = true;
        }

        private void GenerateQuestion()
        {
            if (!timer1.Enabled)
            {
                return;
            }
            angkaPertama = random.Next(1, 15);
            angkaKedua = random.Next(1, 15);

            String[] operators = ["+", "-", "x", "/"];
            operation = operators[random.Next(operators.Length)];

            switch (operation)
            {
                case "+":
                    hasil = angkaPertama + angkaKedua;
                    break;
                case "-":
                    hasil = angkaPertama - angkaKedua;
                    break;
                case "x":
                    hasil = angkaPertama * angkaKedua;
                    break;
                case "/":
                    hasil = angkaPertama / angkaKedua;
                    break;
            }

            labelAngka1.Text = angkaPertama.ToString();
            labelAngka2.Text = angkaKedua.ToString();
            labelOperasi.Text = operation;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                return;
            }

            if (int.TryParse(textBoxHasil.Text, out jawaban))
            {
                if (jawaban == hasil)
                {
                    poin += 10;
                }
            }

            nomorQuiz++;
            labelNomorQuiz.Text = nomorQuiz.ToString() + ".";
            labelHasilPoint.Text = poin.ToString();
            textBoxHasil.Clear();
            GenerateQuestion();
        }

        private void textBoxHasil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEnter.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void buttonTryAgain_Click(object sender, EventArgs e)
        {

        }
    }
}
