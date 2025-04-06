using System;

namespace DeQuiz
{
    public class Quiz
    {
        public int AngkaPertama { get; private set; }
        public int AngkaKedua { get; private set; }
        public string Operation { get; private set; }
        public int Hasil { get; private set; }
        public int Poin { get; private set; }
        public int NomorQuiz { get; private set; }

        private Random random;

        public Quiz()
        {
            random = new Random();
            Poin = 000;
            NomorQuiz = 1;
        }

        public Quiz(int angkaPertama, int angkaKedua, string operation, int hasil, int poin, int nomorQuiz)
        {
            this.AngkaPertama = angkaPertama;
            this.AngkaKedua = angkaKedua;
            this.Operation = operation;
            this.Hasil = hasil;
            this.Poin = poin;
            this.NomorQuiz = nomorQuiz;
        }

        public void GenerateQuestion()
        {
            AngkaPertama = random.Next(1, 15);
            AngkaKedua = random.Next(1, 15);

            string[] operators = { "+", "-", "x", "/" };
            Operation = operators[random.Next(operators.Length)];

            switch (Operation)
            {
                case "+":
                    Hasil = AngkaPertama + AngkaKedua;
                    break;
                case "-":
                    Hasil = AngkaPertama - AngkaKedua;
                    break;
                case "x":
                    Hasil = AngkaPertama * AngkaKedua;
                    break;
                case "/":
                    while (AngkaKedua == 0 || AngkaPertama % AngkaKedua != 0)
                    {
                        AngkaPertama = random.Next(1, 15);
                        AngkaKedua = random.Next(1, 15);
                    }
                    Hasil = AngkaPertama / AngkaKedua;
                    break;
            }
        }

        public bool CekJawaban(int jawabanUser)
        {
            NomorQuiz++;
            if (jawabanUser == Hasil)
            {
                Poin += 10;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            Poin = 000;
            NomorQuiz = 1;
        }
    }
}
