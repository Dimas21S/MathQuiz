using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DeQuiz.ProgramQuiz
{
    public class Quiz
    {
        public string Nama { get; private set; }
        public int AngkaPertama { get; private set; }
        public int AngkaKedua { get; private set; }
        public string Operation { get; private set; }
        public int Hasil { get; private set; }
        public int Poin { get; private set; }
        public int TotalPoin { get; private set; }

        public int NomorQuiz { get; private set; }

        protected const String conString = "server=localhost;port=;database=db_quiz;uid=root;pwd=;";

        private Random random;

        public Quiz()
        {
            random = new Random();
            Poin = 000;
            NomorQuiz = 1;
        }

        public Quiz(string nama, int angkaPertama, int angkaKedua, string operation, int hasil, int poin, int totalPoin ,int nomorQuiz)
        {
            Nama = nama;
            AngkaPertama = angkaPertama;
            AngkaKedua = angkaKedua;
            Operation = operation;
            Hasil = hasil;
            Poin = poin;
            TotalPoin = totalPoin;
            NomorQuiz = nomorQuiz;
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

        public int insertDatabase()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO quiz (Nama, Poin) VALUES(@Nama, @TotalPoin)");
            cmd.Parameters.AddWithValue("@Nama", Nama);
            cmd.Parameters.AddWithValue("@TotalPoin", Poin);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }

    }
}
