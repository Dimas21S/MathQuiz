namespace DeQuiz
{
    public partial class Form1 : Form
    {
        int angkaPertama;
        int angkaKedua;
        int hasil;
        int poin;
        int menit;
        int detik;
        string operation;
        Random random;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            random = new Random();
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
            ;

            labelAngka1.Text = angkaPertama.ToString();
            labelAngka2.Text = angkaKedua.ToString();
            labelOperasi.Text = operation;
            labelHasilPoint.Text = poin.ToString();
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

            labelMinute.Text = menit.ToString("D2");
            labelSeconds.Text = detik.ToString("D2");
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
           
        }
    }
}
