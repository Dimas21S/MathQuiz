using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeQuiz.ProgramQuiz
{
    class Time
    {
        public int Menit { get; private set; }
        public int Detik { get; private set; }

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
    }
}
