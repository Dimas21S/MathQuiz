using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeQuiz.ProgramQuiz
{
    class Time
    {
        public int Menit { get; private set; }
        public int Detik { get; private set; }

        protected const String conString = "server=localhost;port=;database=db_quiz;uid=root;pwd=;";


        public Time(int menit, int detik)
        {
            Menit = menit;
            Detik = detik;
        }

        public Time()
        {

        }

        public void TimeStart()
        {
            Detik++;

            if (Detik == 60)
            {
                Menit++;
                Detik = 0;
            }
        }

        public bool IsTimeUp()
        {
            return Menit == 5;
        }

        public void Reset()
        {
            Menit = 0;
            Detik = 0;
        }

        public int insertDatabase()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO time (Menit, Detik) VALUES(@Menit, @Detik)");
            cmd.Parameters.AddWithValue("@Menit", Menit);
            cmd.Parameters.AddWithValue("@Detik", Detik);
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
