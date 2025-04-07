using DeQuiz.ProgramQuiz;

namespace DeQuiz
{
    public partial class MathQuiz : Form
    {
        int jawaban;
        int menit;
        int detik;
        Quiz quiz;
        Time time;

        public MathQuiz()
        {
            InitializeComponent();
            quiz = new Quiz();
            time = new Time();
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
                time.TimeStart();
            }

            if (time.IsTimeUp())
            {
                timer1.Enabled = false;
                buttonTryAgain.Visible = true;

                if (quiz.NomorQuiz * 10 == quiz.Poin)
                {
                    MessageBox.Show("Terbaik");
                }
            }

            labelMinute.Text = time.Menit.ToString("D2");
            labelSeconds.Text = time.Detik.ToString("D2");
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                if(int.TryParse(textBoxHasil.Text, out jawaban))
                {
                    quiz.CekJawaban(jawaban);
                }
            }
            else
            {
                return;
            }

            labelNomorQuiz.Text = quiz.NomorQuiz.ToString() + ".";
            labelHasilPoint.Text = quiz.Poin.ToString();
            textBoxHasil.Clear();
            quiz.GenerateQuestion();
            TampilkanSoal();
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
            quiz.Reset();
            time.Reset();

            labelHasilPoint.Text = quiz.Poin.ToString("D3");
            labelNomorQuiz.Text = quiz.NomorQuiz.ToString() + ".";
            labelMinute.Text = menit.ToString("D2");
            labelSeconds.Text = detik.ToString("D2");
            textBoxHasil.Clear();
            TampilkanSoal();
        }

        private void TampilkanSoal()
        {
            labelAngka1.Text = quiz.AngkaPertama.ToString();
            labelAngka2.Text = quiz.AngkaKedua.ToString();
            labelOperasi.Text = quiz.Operation;
        }
    }
}
